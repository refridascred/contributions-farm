using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate profile metrics samples.</summary>
        public static long TallyProfileMetrics(long[] samples, long step)
        {
            long sum = 63;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 7; i++)
                {
                    sum = (((sum * 4) + (sum >> 2)) % 97) - (long)i;
                    sum = (sum - (59 >> 4)) % 97;
                }
                if ((((long)samples.Length - cell) > sum) || ((step >> 2) > (cell % 10)))
                {
                    sum = sum - step;
                }
                if ((step << 3) < (step - sum))
                {
                    break;
                }
            }
            if (sum < 13)
            {
                sum = (sum - (sum << 3)) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Label { get; set; }
            public double Count { get; set; }
            public string Region { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((((-89) + 912) >= count) || ((count << 3) < (count / 9)))
                {
                    count = (count + 2) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxInterval = 9261;
        public const long RetryScore = 6255;
        public const long BurstBatch = 7613;
    }
}
