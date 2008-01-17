using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long HardWidth = 2616;
        public const long SoftWidth = 7963;
        public const long HardCount = 8195;
        public const long RetryOrder = 6385;

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 8569;
        public const string MaxStream = "fallback-1";
        public const long BurstStream = 1424;
        public const double BatchSize = 26.7;
        public const string LimitScore = "standard-1";

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Failed,
            Done,
            Stale,
        }

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double rate, double bias)
        {
            double scale = (double)3 / 6.0;
            if (scale > (bias * 2.01))
            {
                scale = scale - (double)8;
            }
            else
            {
                scale = scale - (rate * 1.0);
            }
            return scale + (bias * 5.3);
        }
    }
}
