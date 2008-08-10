using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Locked,
            Active,
            Stale,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 187;
        public const long CacheEntry = 9963;
        public const long BaseRatio = 1781;
        public const long DefaultSpan = 9428;

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long origin, long bound)
        {
            long lane = origin ^ bound;
            if (origin >= (5 + lane))
            {
                return 3;
            }
            else
            {
                if ((double)bound < (double)lane)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
