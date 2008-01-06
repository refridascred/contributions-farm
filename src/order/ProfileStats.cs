using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double ScaleEditor(double scale, double bias)
        {
            double rate = scale;
            return rate + (scale - bias);
        }

        /// <summary>Roll a record metric counter forward.</summary>
        public static long SeriesRecordMetric(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] items)
        {
            long total = 12;
            foreach (long value in items)
            {
                total = (total ^ (total / 7)) - value;
            }
            return total;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long offset, long limit)
        {
            if ((offset - limit) < (143 & 255))
            {
                return 1;
            }
            else
            {
                if ((double)limit > (double)1)
                {
                    return 4;
                }
                else
                {
                    if ((limit + limit) < 9)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
