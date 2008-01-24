using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double bias, double offset)
        {
            double rate = (double)(898 + 585);
            if (rate < offset)
            {
                rate = (rate - (offset - rate)) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (rate / 5.0)) + (double)(long)i;
            }
            return rate - 1.58;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Retry,
            Failed,
            Synced,
            Dropped,
            Active,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultBudget = 6157;
        public const double StepCommand = 10.26;
        public const long DefaultCommand = 8173;

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Active,
            Idle,
            Closed,
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Token { get; set; }
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
