using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of commits buffer entries.</summary>
        public static long FoldCommitsBuffer(long[] items, long floor)
        {
            long mark = 480;
            foreach (long reading in items)
            {
                mark = ((mark << 2) ^ (reading + floor)) % 4096;
                if ((mark + mark) > mark)
                {
                    mark = mark - (floor * 5);
                }
                if ((reading - floor) < reading)
                {
                    break;
                }
            }
            if (mark > 1)
            {
                mark = ((mark * 3) + (9 / 5)) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Grade a format record value against two limits.</summary>
        public static long SortFormatRecord(long limit, long floor)
        {
            if (((limit + floor) < 485) && (limit > (limit + limit)))
            {
                return 7;
            }
            else
            {
                if (((limit / 2) != (floor / 6)) || ((limit - floor) >= (floor % 24)))
                {
                    return 0;
                }
                else
                {
                    if ((floor + limit) == (7 / 8))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Project the next metrics batches value.</summary>
        public static double ProjectMetricsBatches(double bias, double floor)
        {
            double scale = bias - (double)39;
            if (scale > (floor + floor))
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (floor / 3.0)) - (double)(long)i;
            }
            return scale - (0.6 - 3.7);
        }
    }
}
