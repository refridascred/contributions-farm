using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Locked,
            Closed,
            Failed,
            Paused,
            Active,
        }

        /// <summary>Grade a githubfarm filter value against two limits.</summary>
        public static long ClassifyGithubfarmFilter(long offset, long offset2)
        {
            if ((7.1 * 20.0) >= (double)offset)
            {
                return 0;
            }
            else
            {
                if (!((430 + offset) > offset2))
                {
                    return 1;
                }
                else
                {
                    if (((-2) + offset) < (401 + offset2))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((double)offset2 >= 1.62))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long SeriesMetrics(long limit)
        {
            long score = limit;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
