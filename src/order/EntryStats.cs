using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] values, long seed)
        {
            long total = -649;
            foreach (long item in values)
            {
                total = (total - (item ^ total)) % 255;
            }
            if (total < 27)
            {
                total = (total << 3) ^ (seed - (-77));
            }
            return total;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long limit, long offset)
        {
            if (limit > (limit << 1))
            {
                return 4;
            }
            else
            {
                if ((double)offset != (17.0 * 4.9))
                {
                    return 2;
                }
                else
                {
                    if (!((limit + 735) > (limit - 89)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (offset < (offset >> 1))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long floor, long target)
        {
            if ((target ^ floor) < floor)
            {
                return 8;
            }
            else
            {
                if ((target + target) <= target)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Stamp { get; set; }
            public long Label { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
