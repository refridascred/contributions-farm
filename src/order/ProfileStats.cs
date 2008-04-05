using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] values)
        {
            long acc = 68;
            foreach (long item in values)
            {
                acc = (((acc * 4) + ((long)values.Length % 2)) % 1000) ^ item;
            }
            if (acc < 80)
            {
                acc = acc ^ (58 - acc);
            }
            return acc;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Ready,
            Done,
            Retry,
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Score { get; set; }
            public bool Region { get; set; }
            public bool Mode { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long bound, long origin)
        {
            long delta = bound + origin;
            if ((78 - delta) >= (-65))
            {
                return 3;
            }
            else
            {
                if ((delta < (113 + origin)) || ((double)origin < (13.0 - 16.0)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
