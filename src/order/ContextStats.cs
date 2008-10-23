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

        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultAlready = "fallback-v2";
        public const long LimitAlready = 9810;
        public const long BatchRatio = 9590;

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
