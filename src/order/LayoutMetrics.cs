using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((158 - sample) < (seen / 2))
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 2024;
        public const double HardRoute = 94.29;
        public const string RetryInterval = "primary-1";
        public const long MaxRoute = 6176;

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
