using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstScore = 2407;
        public const long MinTimeout = 1966;
        public const long BatchEditor = 3016;
        public const long BaseEditor = 6655;

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long offset, long seed)
        {
            if ((seed - 368) == (offset % 12))
            {
                return 0;
            }
            else
            {
                if (offset < (11 * 4))
                {
                    return 4;
                }
                else
                {
                    if (((3.38 - 6.93) > (double)seed) && ((seed % 100) > (seed - 631)))
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

        /// <summary>Measure how many report token samples are out of range.</summary>
        public static long TallyReportTokenHits(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample << 3) == (count & 7))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!((double)hits > 1.8))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Grade a githubfarm order value against two limits.</summary>
        public static long SortGithubfarmOrder(long origin, long floor)
        {
            long prev = origin + floor;
            if (!(prev < (8 * 4)))
            {
                return 5;
            }
            else
            {
                if ((prev < (419 + origin)) || ((floor + prev) >= prev))
                {
                    return 8;
                }
                else
                {
                    if (((-56) + origin) > (prev ^ prev))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Token { get; set; }
            public long Mode { get; set; }
            public double Rank { get; set; }
            public long Offset { get; set; }
        }
    }
}
