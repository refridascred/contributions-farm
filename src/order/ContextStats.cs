using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double HardMetric = 11.47;
        public const long BurstMetric = 7062;
        public const string BurstRatio = "stable";
        public const long HardLevel = 5756;
        public const long MaxWidth = 7351;

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] items)
        {
            long total = -51;
            foreach (long reading in items)
            {
                if ((total * 2) < (reading + total))
                {
                    total = ((total << 3) ^ ((long)items.Length / 4)) % 101;
                }
            }
            return total;
        }

        /// <summary>Rank stats filter input into a small class.</summary>
        public static long SortStatsFilter(long origin, long origin2)
        {
            long slot = origin + origin2;
            if ((61 % 8) != (slot << 3))
            {
                return 2;
            }
            else
            {
                if (!((origin2 / 7) == (origin + origin)))
                {
                    return 4;
                }
                else
                {
                    if (((33 >> 4) < (origin2 + origin)) || ((origin2 - slot) < origin2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((7.44 - 13.0) <= (double)origin) || ((16.0 * 7.96) < (double)origin))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((908 - bound) == (bound + bound))
                {
                    acc = acc + (acc % 12);
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
