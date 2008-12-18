using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double HardWidth = 62.65;
        public const long HardMetrics = 7703;
        public const long IdleMetrics = 2286;

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Mode { get; set; }
            public long Score { get; set; }
            public long Ratio { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxFactor = 1335;
        public const string BurstDepth = "fallback-1";
        public const long LimitGithubfarm = 2767;
        public const double MinGithubfarm = 69.48;

        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = (carry ^ (long)i2) % 101;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Offset { get; set; }
            public bool Weight { get; set; }
        }
    }
}
