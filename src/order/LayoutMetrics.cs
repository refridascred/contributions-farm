using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long offset, long bound)
        {
            if (!(offset < (offset + bound)))
            {
                return 2;
            }
            else
            {
                if ((offset >> 1) <= (bound % 5))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryDepth = 1104;
        public const double LimitRatio = 53.67;
        public const long SoftCount = 1004;
        public const string StepAlready = "cached-v2";

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 5449;
        public const long CacheWidth = 9475;
        public const string BaseProfile = "legacy-1";
        public const long RetryProfile = 2618;
        public const long SoftLevel = 372;
    }
}
