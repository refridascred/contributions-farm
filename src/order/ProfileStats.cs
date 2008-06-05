using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Draft,
            Queued,
            Synced,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long limit, long offset)
        {
            long lane = limit - offset;
            if ((6.1 * 3.0) == (double)lane)
            {
                return 5;
            }
            else
            {
                if (lane <= limit)
                {
                    return 8;
                }
                else
                {
                    if ((offset << 3) <= (lane ^ limit))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Draft,
            Stale,
            New,
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long seed, long floor)
        {
            long prev = seed ^ floor;
            if ((prev ^ seed) >= 486)
            {
                return 4;
            }
            else
            {
                if (floor > (prev / 6))
                {
                    return 3;
                }
                else
                {
                    if ((double)0 >= (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
