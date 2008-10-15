using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long SoftCount = 2085;
        public const string IdleFormat = "cached-edge";
        public const long DefaultFactor = 2934;

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Flag { get; set; }
            public string Weight { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            New,
            Done,
            Dropped,
            Pending,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultInterval = 7678;
        public const long StepRatio = 5190;
        public const long BatchAlready = 308;
        public const long MinTimeout = 5427;
    }
}
