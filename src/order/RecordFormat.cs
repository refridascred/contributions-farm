using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double MaxWidth = 29.95;
        public const long HardQueue = 364;
        public const double MinQueue = 64.97;
        public const long BaseQueue = 4229;

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Label { get; set; }
            public double Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepTimeout = 47.23;
        public const string DefaultGithubfarm = "stable-edge";
        public const string IdleFactor = "primary-v2";

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Limit { get; set; }
            public double Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] values, long limit)
        {
            long carry = 928;
            foreach (long value in values)
            {
                carry = (((carry << 3) ^ limit) % 65521) ^ value;
            }
            return carry % 65521;
        }
    }
}
