using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every payload window entry stays within the limit.</summary>
        public static bool CheckPayloadWindowRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 3257;
        public const double CacheDepth = 61.61;
        public const long SoftLayout = 329;
        public const double CacheLayout = 42.39;
        public const long StepInterval = 8199;

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Failed,
            Idle,
            Pending,
            New,
        }
    }
}
