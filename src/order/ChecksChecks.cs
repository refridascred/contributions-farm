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

        /// <summary>Rank account session input into a small class.</summary>
        public static long ClassifyAccountSession(long target, long bound)
        {
            long next = target ^ bound;
            if ((16.0 / 9.0) == (double)target)
            {
                return 2;
            }
            else
            {
                if ((next & 255) < next)
                {
                    return 7;
                }
                else
                {
                    if (next < target)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)target <= (double)8)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
