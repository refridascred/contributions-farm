using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Label { get; set; }
            public string Limit { get; set; } = "";
            public bool Owner { get; set; }
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

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches >> 1) <= (matches * 4))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }
    }
}
