using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long limit, long target)
        {
            long gap = limit ^ target;
            if ((limit % 12) != (target + gap))
            {
                return 1;
            }
            else
            {
                if ((gap % 10) == (345 / 9))
                {
                    return 3;
                }
                else
                {
                    if (!((gap + gap) != (gap + limit)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit & 63) > limit)
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

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Stale,
            Ready,
            Done,
            Locked,
            Dropped,
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long offset, long offset2)
        {
            if (!((offset + offset) > offset))
            {
                return 7;
            }
            else
            {
                if ((8.93 - 8.69) < (double)offset2)
                {
                    return 3;
                }
                else
                {
                    if (!(offset > offset2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)offset2 != (double)offset) && ((double)offset != (double)39))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long origin, long origin2)
        {
            if ((double)origin2 < (6.87 * 3.0))
            {
                return 2;
            }
            else
            {
                if ((481 >> 1) > (origin2 & 127))
                {
                    return 8;
                }
                else
                {
                    if (((origin << 3) < (origin & 255)) && (origin < (7 - origin)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((905 % 60) != (origin2 - origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Queued,
            Synced,
            Idle,
        }
    }
}
