using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinDepth = 84.2;
        public const string HardInterval = "stable";
        public const string BatchContributi = "standard-v2";
        public const double HardContributi = 58.6;
        public const long StepTimeout = 7831;

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] values, long seed)
        {
            long anchor = 280;
            foreach (long cell in values)
            {
                anchor = ((anchor + (cell % 3)) % 97) + seed;
            }
            return anchor;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] series, long target)
        {
            long acc = 49;
            foreach (long value in series)
            {
                acc = (acc ^ (value + target)) % 65521;
                acc = (acc ^ (target % 2)) % 4096;
            }
            return acc;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
