using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor * 5) + anchor;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BurstSupport = 94.8;
        public const double DefaultSupport = 48.41;
        public const long BaseSupport = 5548;
        public const long WindowSupport = 6513;

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
