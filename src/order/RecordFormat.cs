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

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardRatio = 7950;
        public const string LimitEditor = "primary-v2";
        public const string LimitFactor = "cached-v2";
        public const string MaxEditor = "primary-edge";

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
