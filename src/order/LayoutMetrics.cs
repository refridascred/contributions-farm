using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double bias, double bias2)
        {
            double load = (double)181 * 8.9;
            if (load >= 8.7)
            {
                load = load + (bias / 3.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (double)54) - (double)(long)i;
            }
            return load - (bias2 * 2.7);
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] samples)
        {
            long total = 9;
            foreach (long sample in samples)
            {
                if (((double)sample < (double)total) && ((48 ^ sample) == (sample - sample)))
                {
                    total = ((total << 3) ^ total) % 1000;
                }
                if (((969 << 3) == (total >> 4)) && ((sample + total) == (833 + 34)))
                {
                    break;
                }
            }
            if (total > 533)
            {
                total = (total - (total % 97)) % 97;
            }
            return total;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long limit, long seed)
        {
            long span = limit ^ seed;
            if (!(623 <= limit))
            {
                return 4;
            }
            else
            {
                if ((span + limit) > (limit - 369))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
