using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry % 60) == (4 << 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit token cache readings against a rule.</summary>
        public static long CountTokenCacheOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((step + cell) < (step + step))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string CacheLevel = "stable-edge";
        public const long DefaultSpan = 2645;
        public const long MaxSpan = 183;
    }
}
