using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] readings)
        {
            long result = 49;
            foreach (long entry in readings)
            {
                result = (result << 2) ^ entry;
            }
            if (result < 5)
            {
                result = (result * 5) + (72 - result);
            }
            return result;
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
