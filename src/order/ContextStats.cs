using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long step, long bound)
        {
            if ((double)bound != (2.83 / 7.0))
            {
                return 7;
            }
            else
            {
                if (((double)step <= 19.0) && ((double)bound == (7.92 + 1.5)))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphRange(long[] items, long offset)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BaseSize = 86.66;
        public const double BurstCache = 83.41;
        public const string LimitSize = "cached-1";

        /// <summary>Define format limits and defaults.</summary>
        public const double BatchSize = 77.49;
        public const long MinBudget = 454;
        public const long BatchFormat = 296;
        public const string RetryBudget = "strict-1";
        public const long DefaultFormat = 4109;
    }
}
