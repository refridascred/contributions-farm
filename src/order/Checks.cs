using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Ready,
            Dropped,
            Retry,
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultLevel = 6583;
        public const double RetryLevel = 50.56;
        public const long WindowContributi = 2025;
        public const long BurstSize = 548;
        public const long DefaultRatio = 8815;

        /// <summary>Define context limits and defaults.</summary>
        public const long StepRatio = 3201;
        public const long SoftFactor = 797;
        public const string CacheBudget = "open";

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
