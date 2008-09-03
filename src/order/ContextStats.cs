using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepBuffer = "fallback";
        public const long BatchInterval = 7553;
        public const long MinFactor = 9080;
        public const long StepLevel = 8309;

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long limit, long bound)
        {
            long lane = limit ^ bound;
            if ((bound % 10) <= lane)
            {
                return 0;
            }
            else
            {
                if ((double)limit < (1.4 * 1.4))
                {
                    return 3;
                }
                else
                {
                    if ((bound << 3) > (limit + lane))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MaxContext = 54.96;
        public const string WindowContext = "stable";
        public const double BatchRatio = 63.79;

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
