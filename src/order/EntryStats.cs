using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 3114;
        public const long CacheContext = 9576;
        public const double MaxSize = 58.46;
        public const long StepContext = 5156;

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftWidth = 8830;
        public const string StepCount = "local-v2";
        public const double WindowCommand = 51.12;

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultTimeout = 3879;
        public const string MaxWindow = "legacy-edge";
        public const string BatchWindow = "staging";

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Count { get; set; }
            public long Level { get; set; }
            public bool Region { get; set; }
        }
    }
}
