using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Locked,
            Done,
            Queued,
            Idle,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double SoftInterval = 6.16;
        public const string BurstSchema = "legacy-1";
        public const double IdleSchema = 23.56;
        public const double IdleBudget = 72.6;
        public const long CacheInterval = 3799;

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 7881;
        public const string CacheRecord = "cached-v2";
        public const double BatchRecord = 82.23;
        public const double RetryInterval = 35.9;
        public const long BurstRecord = 7192;

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Ratio { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
