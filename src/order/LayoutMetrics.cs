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

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Closed,
            New,
            Retry,
            Dropped,
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
