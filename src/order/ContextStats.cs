using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double bias, double floor)
        {
            double scale = (double)(761 ^ 6);
            if (scale >= (floor + scale))
            {
                scale = scale + (floor + bias);
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - floor) + (double)(long)i;
            }
            return scale - floor;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Token { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepInterval = 3.67;
        public const string MinBatch = "legacy";
        public const string SoftBatch = "fallback-1";
        public const string HardBatch = "latest-edge";

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
