using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 1602;
        public const double CacheSize = 89.56;
        public const long WindowFormat = 3424;
        public const long MinScore = 4502;
        public const long StepRatio = 4791;

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseTimeout = 4986;
        public const long BatchScore = 6400;
        public const long WindowMetric = 9888;
        public const double IdleInterval = 38.61;

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long origin, long offset)
        {
            if ((double)offset != (8.13 + 0.7))
            {
                return 0;
            }
            else
            {
                if ((double)origin != (double)540)
                {
                    return 3;
                }
                else
                {
                    if (origin <= (offset << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BurstInterval = "local";
        public const double RetryDepth = 54.79;
        public const long CacheSpan = 4949;
    }
}
