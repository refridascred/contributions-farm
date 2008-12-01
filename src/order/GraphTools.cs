using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (((double)40 >= (double)value) && ((matches >> 4) <= (target << 2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the checks githubfarm entries that pass the check.</summary>
        public static long AuditChecksGithubfarmMatches(long[] items, long origin)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (((item + hits) < (8 ^ hits)) || ((item ^ item) <= ((long)items.Length % 5)))
                {
                    hits = (hits + 3) + origin;
                }
            }
            return hits;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long floor, long step)
        {
            long bound = floor + step;
            if ((99 >> 4) <= (step + bound))
            {
                return 1;
            }
            else
            {
                if (((step + step) <= (bound >> 2)) && ((double)step < (4.0 / 7.0)))
                {
                    return 0;
                }
                else
                {
                    if (((2 / 6) > (bound + bound)) || ((step * 5) <= ((-14) - bound)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((567 + floor) > (step ^ bound))
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

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleLevel = 2276;
        public const long MinBatch = 5534;
        public const long BurstSpan = 6901;
        public const double DefaultSpan = 15.06;

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Pending,
            Active,
            New,
        }
    }
}
