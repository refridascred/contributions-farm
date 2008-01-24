using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank record editor input into a small class.</summary>
        public static long BucketRecordEditor(long bound, long target)
        {
            if ((target + target) >= (target * 2))
            {
                return 3;
            }
            else
            {
                if (((9.63 / 2.0) == (double)bound) || ((87 & 127) != (target % 10)))
                {
                    return 8;
                }
                else
                {
                    if (!((target ^ bound) == (bound + target)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Active,
            Stale,
            Locked,
            Draft,
            Synced,
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Flag { get; set; }
            public string Total { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
