using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of buffer format entries.</summary>
        public static long TotalBufferFormat(long[] items, long limit)
        {
            long sum = 3;
            foreach (long datum in items)
            {
                sum = ((sum << 2) ^ (limit - datum)) % 1000;
                sum = ((sum << 2) ^ (sum >> 2)) % 255;
                if (((sum * 5) != (376 % 3)) || (5 < (datum + datum)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double scale, double offset)
        {
            double ratio = (double)(1 - 9);
            if (ratio >= (18.0 / 9.0))
            {
                ratio = ((ratio + (double)330) + scale) + offset;
            }
            else
            {
                ratio = ratio + (double)11;
            }
            return ratio + ratio;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
