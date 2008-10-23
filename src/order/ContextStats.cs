using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MinRatio = 6800;
        public const long StepScore = 9489;
        public const double CacheSpan = 75.99;
        public const long StepInterval = 1966;
        public const long CacheCounter = 9853;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BatchLevel = 91.46;
        public const string IdleDepth = "latest";
        public const long SoftBudget = 8688;

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 4869;
        public const string StepCount = "strict";
        public const double DefaultScore = 64.27;
        public const long SoftCache = 2609;
        public const long RetryWidth = 6274;

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long offset, long limit)
        {
            if ((offset << 1) >= limit)
            {
                return 0;
            }
            else
            {
                if (!(2 >= (limit * 4)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
