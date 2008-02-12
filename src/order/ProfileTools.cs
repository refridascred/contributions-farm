using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
