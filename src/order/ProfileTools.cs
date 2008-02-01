using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a contributi checks value against two limits.</summary>
        public static long BucketContributiChecks(long limit, long step)
        {
            long cur = limit - step;
            if (((3 ^ 292) != (step / 7)) && ((61 - step) == (cur + 76)))
            {
                return 4;
            }
            else
            {
                if (cur >= (step ^ cur))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
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

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == bound) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
