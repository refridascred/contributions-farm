using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long seed, long step)
        {
            if ((seed - step) <= (step ^ step))
            {
                return 5;
            }
            else
            {
                if (step < (seed + step))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double LimitDepth = 37.3;
        public const double MinLevel = 66.46;
        public const long BatchDepth = 5017;
        public const double CacheDepth = 54.37;
    }
}
