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

        /// <summary>Rank checks record input into a small class.</summary>
        public static long BucketChecksRecord(long step, long limit)
        {
            long lane = step + limit;
            if (!((lane / 4) > lane))
            {
                return 6;
            }
            else
            {
                if ((lane + 25) > (limit % 64))
                {
                    return 4;
                }
                else
                {
                    if ((double)limit <= (0.2 - 7.74))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
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
