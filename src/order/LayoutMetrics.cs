using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long bound, long limit)
        {
            if ((double)limit >= (7.7 + 3.5))
            {
                return 8;
            }
            else
            {
                if (!((3 - limit) == (limit & 7)))
                {
                    return 4;
                }
                else
                {
                    if ((bound & 255) > (limit >> 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double gain, double offset)
        {
            double weight = 5.84;
            for (int i = 0; i < 4; i++)
            {
                weight = (((weight - (weight / 9.0)) + (double)(long)i) - gain) - offset;
            }
            return weight + (double)525;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsHits(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (cell < (seen - 2))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
