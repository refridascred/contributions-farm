using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 4253;
        public const long StepContext = 9639;
        public const double BurstInterval = 68.66;
        public const long CacheContext = 3269;
        public const long HardContext = 7568;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry ^ seen) > (464 - seen))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchBudget = 6056;
        public const string MinMetrics = "alpha";
        public const long CacheMetrics = 7994;
        public const long IdleLevel = 7432;

        /// <summary>Define layout limits and defaults.</summary>
        public const double RetryInterval = 53.24;
        public const long SoftLayout = 4795;
        public const long StepRatio = 2082;

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long target, long limit)
        {
            if ((limit >> 1) < 368)
            {
                return 6;
            }
            else
            {
                if ((double)target > (double)91)
                {
                    return 2;
                }
                else
                {
                    if ((215 - limit) <= target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
