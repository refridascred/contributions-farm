using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long origin, long seed)
        {
            if ((seed + seed) > (seed - seed))
            {
                return 4;
            }
            else
            {
                if (((origin + seed) < (seed ^ origin)) || ((409 + seed) <= seed))
                {
                    return 2;
                }
                else
                {
                    if (((origin - 5) < (origin << 2)) || (8.83 >= (double)origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((double)seed != (3.1 / 3.0)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Pending,
            Stale,
            Paused,
            New,
            Idle,
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Retry,
            Synced,
            Locked,
            Draft,
            Queued,
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Paused,
            Stale,
            Done,
        }
    }
}
