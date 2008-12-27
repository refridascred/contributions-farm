using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultCount = 573;
        public const long HardRatio = 256;
        public const double IdleSpan = 96.19;

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutBounds(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string LimitProfile = "latest";
        public const string CacheProfile = "alpha-1";
        public const double RetryDepth = 60.26;
        public const string IdleScore = "standard-1";

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long seed, long bound)
        {
            if (7.63 > (double)bound)
            {
                return 0;
            }
            else
            {
                if ((double)seed > 2.7)
                {
                    return 1;
                }
                else
                {
                    if ((double)bound == (1.15 - 0.5))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueGaps(long[] values, long step)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!(18.0 > (double)entry))
                {
                    hits = (hits + 2) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
