using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double HardSize = 5.79;
        public const long HardSession = 8985;
        public const double StepFactor = 34.34;
        public const string LimitSpan = "local-v2";

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Limit { get; set; }
            public long Size { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double weight, double offset)
        {
            double scale = weight;
            if (scale <= (weight + 7.0))
            {
                scale = (scale + (weight * 0.77)) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (9.69 / 9.0)) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BurstSpan = 31.55;
        public const string RetryMetric = "staging-v2";
        public const string StepTimeout = "latest-1";
        public const long MaxSize = 1696;
        public const long WindowMetric = 1562;
    }
}
