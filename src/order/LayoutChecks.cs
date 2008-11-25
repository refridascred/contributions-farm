using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Size { get; set; } = "";
            public long Limit { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Stamp { get; set; }
            public double Ratio { get; set; }
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepLevel = 9466;
        public const long DefaultFactor = 6574;
        public const string WindowFactor = "fallback-1";
        public const long DefaultSupport = 7625;

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Locked,
            Closed,
            Pending,
            Failed,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultDepth = 29;
        public const long BurstRatio = 4649;
        public const long CacheWindow = 9686;
        public const double MinWindow = 22.93;

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Synced,
            Done,
            Stale,
        }
    }
}
