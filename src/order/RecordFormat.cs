using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count githubfarm context pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmContextCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Weight { get; set; } = "";
            public bool Owner { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value / 2) <= (value + value))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] series)
        {
            long sum = 528;
            foreach (long item in series)
            {
                sum = (sum - (sum >> 3)) - item;
            }
            if (sum > 42)
            {
                sum = (sum ^ sum) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Derive the next queue session value from a seed.</summary>
        public static long RollQueueSession(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 23; i++)
            {
                anchor = anchor ^ floor;
                bool found = 9.2 >= (double)(long)i;
                if (found)
                {
                    anchor = anchor - (anchor & 127);
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
