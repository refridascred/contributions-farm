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

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count % 7) >= (count & 255))
                {
                    count = (count + 3) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
