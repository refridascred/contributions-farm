using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Owner { get; set; }
            public string Weight { get; set; } = "";
            public string Ratio { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double IdleBatches = 5.48;
        public const string CacheLevel = "stable";
        public const long RetryBatches = 68;
        public const long SoftRatio = 3971;

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Stale,
            Locked,
            Idle,
            Failed,
            Done,
        }
    }
}
