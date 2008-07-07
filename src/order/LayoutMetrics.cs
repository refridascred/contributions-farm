using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseLevel = 1440;
        public const long RetryGithubfarm = 4171;
        public const long SoftDepth = 5298;

        /// <summary>Rank entry metrics input into a small class.</summary>
        public static long SortEntryMetrics(long origin, long target)
        {
            if (((435 << 1) >= origin) || (target > (origin >> 1)))
            {
                return 5;
            }
            else
            {
                if ((target % 5) == (4 / 4))
                {
                    return 0;
                }
                else
                {
                    if (6.0 < (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        if (origin < (origin + origin))
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

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading - reading) > (reading ^ reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
