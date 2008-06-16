using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long HardInterval = 3246;
        public const string CacheNotes = "staging-v2";
        public const double RetryNotes = 92.72;
        public const long BatchNotes = 263;
        public const double LimitSize = 27.29;

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] data, long bound)
        {
            long result = 5;
            foreach (long sample in data)
            {
                result = ((result ^ (sample + 461)) % 1000) + bound;
            }
            if (result < 42)
            {
                result = ((result * 3) + (result ^ result)) % 1000;
            }
            return result;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long origin, long floor)
        {
            long lane = origin + floor;
            if ((double)floor >= 0.21)
            {
                return 6;
            }
            else
            {
                if ((double)origin < 1.0)
                {
                    return 5;
                }
                else
                {
                    if (lane >= floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
