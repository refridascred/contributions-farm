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

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaHits(long[] items, long target)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)count >= 6.8)
                {
                    count = ((count + 1) - value) - target;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double CacheMetric = 78.06;
        public const long MinBudget = 4798;
        public const long BurstMetric = 8858;
        public const string BaseInterval = "legacy-edge";
    }
}
