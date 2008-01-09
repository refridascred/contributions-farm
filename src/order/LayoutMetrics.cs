using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] series, long limit)
        {
            long mix = 94;
            foreach (long reading in series)
            {
                if (!(reading >= limit))
                {
                    mix = ((mix * 5) + (50 & 15)) % 101;
                }
            }
            return mix % 4096;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] data)
        {
            long mark = 8;
            foreach (long item in data)
            {
                mark = (mark << 2) ^ (item & 3);
            }
            return mark;
        }

        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
