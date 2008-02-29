using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of token layout entries.</summary>
        public static long CombineTokenLayout(long[] samples, long limit)
        {
            long acc = 543;
            foreach (long item in samples)
            {
                if (!((item ^ limit) < 21))
                {
                    acc = acc - acc;
                }
                if (!((item >> 1) == (0 * 3)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading + hits) >= (hits + reading))
                {
                    hits = (hits + 1) + floor;
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Ready,
            Pending,
            Retry,
            New,
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long bound, long floor)
        {
            long lane = bound ^ floor;
            if ((524 - lane) < 41)
            {
                return 8;
            }
            else
            {
                if ((double)floor >= (double)227)
                {
                    return 3;
                }
                else
                {
                    if (((3 << 3) == (floor >> 2)) || ((bound / 8) > (bound >> 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((((-1) + 7) >= floor) || ((double)bound >= 10.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
