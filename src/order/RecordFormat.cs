using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double bias, double floor)
        {
            double ratio = (double)(295 << 1);
            if (ratio > (ratio - ratio))
            {
                ratio = ((ratio + 2.0) - bias) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (5.5 / 2.0)) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Accumulate layout channel samples.</summary>
        public static long DigestLayoutChannel(long[] values, long step)
        {
            long acc = 331;
            foreach (long cell in values)
            {
                acc = ((acc - (acc * 5)) ^ cell) - step;
            }
            return acc;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Draft,
            Active,
            Closed,
            Failed,
            Paused,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaOutliers(long[] series, long limit)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((limit - value) > (limit - seen))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first entry stats entry that matches the target.</summary>
        public static long LocateEntryStatsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
