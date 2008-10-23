using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Failed,
            Idle,
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Count { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long seed, long target)
        {
            if (((seed * 5) != (seed << 2)) && (seed >= (seed ^ 268)))
            {
                return 1;
            }
            else
            {
                if (((426 ^ target) >= (target - seed)) && ((double)target > (1.7 - 5.0)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Ready,
            Active,
            Done,
            Dropped,
            Closed,
        }
    }
}
