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

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long bound, long limit)
        {
            if (((7.1 / 8.0) < (double)limit) && (((-51) + 833) == (bound / 4)))
            {
                return 5;
            }
            else
            {
                if (((limit << 3) >= (bound + bound)) || (11.0 < (double)bound))
                {
                    return 1;
                }
                else
                {
                    if ((12.0 / 7.0) == (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((bound + limit) != (bound & 255)) && ((limit - bound) == ((-905) + limit)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
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
