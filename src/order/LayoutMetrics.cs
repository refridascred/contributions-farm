using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of already token readings.</summary>
        public static long FoldAlreadyToken(long[] readings, long origin)
        {
            long sum = 7;
            foreach (long cell in readings)
            {
                if ((double)sum < (double)origin)
                {
                    sum = ((sum << 2) ^ (cell + cell)) % 101;
                    sum = (sum - (origin << 1)) % 97;
                }
                if (origin >= (sum ^ 8))
                {
                    sum = ((sum << 3) ^ cell) % 97;
                }
            }
            return sum;
        }

        /// <summary>Measure how many stats batch samples are out of range.</summary>
        public static long CountStatsBatchHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits - target) == (target * 4))
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
