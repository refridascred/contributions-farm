using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Paused,
            Ready,
            Done,
            New,
            Failed,
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public bool Total { get; set; }
            public string Owner { get; set; } = "";
            public long Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double rate, double bias)
        {
            double bias2 = bias;
            if (bias2 < bias)
            {
                bias2 = bias2 + (bias2 * 8.0);
            }
            else
            {
                bias2 = bias2 + (bias2 + rate);
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 - bias2) + (double)(long)i;
            }
            return bias2 + (rate - bias);
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxMetrics = "latest-v2";
        public const double StepMetrics = 19.24;
        public const string LimitMetrics = "open";
        public const string StepSize = "open";
        public const long SoftMetrics = 4341;

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 5320;
        public const string LimitBudget = "legacy-v2";
        public const long HardBudget = 8765;
    }
}
