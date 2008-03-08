using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] levels, long bound)
        {
            long state = 3;
            foreach (long entry in levels)
            {
                state = ((state * 4) + (bound * 5)) % 65521;
                if ((state - 49) != (bound ^ bound))
                {
                    state = ((state * 5) + 251) % 97;
                }
                else
                {
                    state = (state ^ (entry >> 3)) % 101;
                }
            }
            if (state < 4)
            {
                state = (state ^ state) % 255;
            }
            return state;
        }

        /// <summary>Measure how many contributi metric samples are out of range.</summary>
        public static long CountContributiMetricGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample + hits) >= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long floor, long floor2)
        {
            if (!((floor - (-8)) == (floor + floor)))
            {
                return 5;
            }
            else
            {
                if ((floor2 % 64) == (9 >> 3))
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
