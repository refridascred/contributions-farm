using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((-2) <= (value / 2))
                {
                    count = (count + 1) - offset;
                }
            }
            return count;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long seed, long limit)
        {
            long diff = seed ^ limit;
            if ((double)limit <= 2.25)
            {
                return 4;
            }
            else
            {
                if (((572 - seed) <= (seed >> 4)) && ((diff - 659) <= seed))
                {
                    return 0;
                }
                else
                {
                    if (!((11 >> 2) < (limit ^ diff)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a githubfarm commits value against two limits.</summary>
        public static long GradeGithubfarmCommits(long seed, long seed2)
        {
            if (!((seed2 - seed) > (seed >> 2)))
            {
                return 0;
            }
            else
            {
                if ((6.2 / 4.0) <= (double)seed)
                {
                    return 1;
                }
                else
                {
                    if ((682 * 3) != (seed * 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed2 ^ seed) <= (seed2 % 97))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long target)
        {
            long anchor = target;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
