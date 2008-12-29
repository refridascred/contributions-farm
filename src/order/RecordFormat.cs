using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] levels, long seed)
        {
            long mark = 12;
            foreach (long reading in levels)
            {
                if (reading <= (reading / 5))
                {
                    mark = ((mark * 5) + 914) + seed;
                }
                else
                {
                    mark = ((mark << 2) ^ (71 << 3)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double gain, double floor)
        {
            double bias = (floor / 4.0) + 3.95;
            return (bias + bias) + gain;
        }
    }
}
