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

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] data)
        {
            long mix = 60;
            foreach (long reading in data)
            {
                if ((double)mix <= 8.05)
                {
                    mix = mix + reading;
                }
                else
                {
                    mix = (mix * 3) + (7 ^ 67);
                }
            }
            if (mix > 704)
            {
                mix = (mix - mix) % 255;
            }
            return mix;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string CacheLevel = "stable-edge";
        public const long DefaultSpan = 2645;
        public const long MaxSpan = 183;
    }
}
