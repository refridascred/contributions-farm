using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double BaseFactor = 54.36;
        public const string SoftFactor = "fallback-v2";
        public const long SoftProfile = 815;

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double bias, double floor)
        {
            double load = (double)(38 / 6);
            if (load >= floor)
            {
                load = (load - floor) - bias;
            }
            return load - load;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Queued,
            Dropped,
            Pending,
            Failed,
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double ratio, double floor)
        {
            double drift = ratio;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - floor) + (double)(long)i;
            }
            return drift - ratio;
        }

        /// <summary>Adjust a order batch reading.</summary>
        public static double SmoothOrderBatch(double scale, double bias)
        {
            double drift = (scale / 8.0) - (scale - scale);
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + (scale * 4.46);
        }
    }
}
