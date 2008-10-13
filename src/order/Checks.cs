using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long step, long target)
        {
            if ((3.9 * 5.37) != (double)step)
            {
                return 6;
            }
            else
            {
                if (((target << 1) == (target - 214)) && ((3 ^ target) != (target >> 4)))
                {
                    return 2;
                }
                else
                {
                    if ((target / 9) <= (target ^ step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
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
