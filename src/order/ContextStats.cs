using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next cache metrics value from a seed.</summary>
        public static long IterateCacheMetrics(long step)
        {
            long anchor = step;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Validate already layout readings against a bound.</summary>
        public static bool ValidateAlreadyLayoutLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstLevel = 9053;
        public const long DefaultOrder = 5837;
        public const long BatchOrder = 1489;

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxTimeout = 7931;
        public const long MinSession = 4481;
        public const long IdleSession = 1893;
        public const double BatchSession = 67.4;
        public const long BaseSession = 2714;
    }
}
