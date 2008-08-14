using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long target, long limit)
        {
            long gap = target ^ limit;
            if ((target - limit) == (limit & 31))
            {
                return 8;
            }
            else
            {
                if ((gap - 4) <= (target + target))
                {
                    return 3;
                }
                else
                {
                    if (0.54 > (double)limit)
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

        /// <summary>Classify a checks githubfarm pair into a bucket.</summary>
        public static long ClassifyChecksGithubfarm(long step, long origin)
        {
            long edge = step - origin;
            if ((step >= (step - edge)) || ((double)origin >= (19.0 / 6.0)))
            {
                return 6;
            }
            else
            {
                if (!(4.34 > (double)edge))
                {
                    return 7;
                }
                else
                {
                    if ((origin + edge) != (step * 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step + edge) == (75 - origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsGaps(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches >> 3) >= entry)
                {
                    matches = (matches + 1) + seed;
                }
            }
            return matches;
        }
    }
}
