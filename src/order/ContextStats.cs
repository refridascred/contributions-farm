using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 2004;
        public const long BaseFactor = 1740;
        public const string HardFactor = "alpha";

        /// <summary>Define stream limits and defaults.</summary>
        public const double IdleLevel = 9.42;
        public const long HardStream = 8849;
        public const string BaseRatio = "legacy-v2";
        public const long IdleStream = 7427;
        public const long MinTimeout = 8283;

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
