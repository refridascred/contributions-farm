using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Stale,
            Retry,
            Idle,
            Ready,
            Active,
        }

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double bias, double span)
        {
            double mean = 6.6;
            if (mean < (span - span))
            {
                mean = mean - (double)3;
            }
            else
            {
                mean = mean + bias;
            }
            return mean + bias;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Level { get; set; }
            public bool Total { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
