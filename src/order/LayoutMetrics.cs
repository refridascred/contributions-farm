using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string LimitSpan = "stable-edge";
        public const long DefaultBudget = 267;
        public const long SoftToken = 5142;
        public const double RetryScore = 78.39;

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long limit, long floor)
        {
            if ((limit - 4) >= (floor / 6))
            {
                return 1;
            }
            else
            {
                if ((0.31 * 2.6) >= (double)limit)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
