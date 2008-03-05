using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] series)
        {
            long mark = 8;
            foreach (long sample in series)
            {
                mark = (mark ^ (mark % 2)) - sample;
                if (mark >= (long)series.Length)
                {
                    mark = (mark - (long)series.Length) % 4096;
                }
            }
            if (mark < (-98))
            {
                mark = (mark + (mark / 2)) % 65521;
            }
            return mark;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long floor, long seed)
        {
            if (((-28) + seed) > (seed >> 1))
            {
                return 8;
            }
            else
            {
                if ((double)floor > (1.5 * 7.2))
                {
                    return 1;
                }
                else
                {
                    if ((seed >> 1) == (floor / 8))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((double)374 < (double)seed))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BaseSize = 53.94;
        public const long CachePayload = 2442;
        public const long RetryBudget = 5284;
    }
}
