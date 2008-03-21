using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] values)
        {
            long mark = 27;
            foreach (long datum in values)
            {
                mark = ((mark * 3) + (datum + 966)) % 101;
                if (((-80) ^ datum) < (916 >> 1))
                {
                    mark = (mark << 2) ^ (datum + mark);
                }
            }
            return mark % 1000;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((count % 24) == (datum - 73)) || (((1.38 + 10.0) != (double)count) || ((datum / 2) <= (datum - datum))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double ratio, double offset)
        {
            double rate = ratio;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate - 9.7) - (double)(long)i) + offset;
            }
            return rate - rate;
        }

        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
