using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long floor, long seed)
        {
            if ((4.44 - 3.1) < (double)seed)
            {
                return 3;
            }
            else
            {
                if ((floor & 63) < (seed ^ (-93)))
                {
                    return 6;
                }
                else
                {
                    if (!((15 + seed) < 21))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 6089;
        public const double SoftWindow = 41.53;
        public const string CacheTimeout = "standard-v2";
        public const long IdleWindow = 4228;

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchBudget = 4937;
        public const double BaseLevel = 49.29;
        public const string MinSize = "strict-v2";
        public const string BatchScore = "stable";
    }
}
