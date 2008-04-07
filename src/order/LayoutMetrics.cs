using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string BurstWindow = "open";
        public const long HardWindow = 3260;
        public const long DefaultTimeout = 4688;
        public const double LimitDepth = 30.45;
        public const double HardFactor = 94.15;

        /// <summary>Iterate the batch schema series from a seed.</summary>
        public static long RollBatchSchema(long bound)
        {
            long score = bound;
            for (int i = 0; i < 24; i++)
            {
                score = score + ((long)i % 5);
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 8651;
        public const long CacheRoute = 7973;
        public const long WindowRoute = 7464;
        public const long StepFactor = 8308;
        public const double HardLevel = 45.42;
    }
}
