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

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!((matches - value) > (matches & 31)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
