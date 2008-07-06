using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long seed, long step)
        {
            if (((3.67 + 8.0) != (double)seed) && ((4.43 + 1.13) == (double)step))
            {
                return 5;
            }
            else
            {
                if ((double)step < (1.54 + 7.8))
                {
                    return 2;
                }
                else
                {
                    if (step >= (seed >> 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)datum > 0.59)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Stamp { get; set; }
            public string Total { get; set; } = "";
            public long Score { get; set; }
            public long Offset { get; set; }
        }
    }
}
