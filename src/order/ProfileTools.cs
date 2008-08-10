using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Dropped,
            Active,
            Locked,
            Failed,
            Paused,
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Done,
            Queued,
            Ready,
            Idle,
            Pending,
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long seed, long limit)
        {
            if (((8.0 / 4.0) == (double)seed) && ((seed + seed) >= (seed + limit)))
            {
                return 8;
            }
            else
            {
                if (limit < (limit >> 3))
                {
                    return 1;
                }
                else
                {
                    if ((limit << 1) > (seed + 243))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((16.0 - 8.6) >= (double)limit)
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
