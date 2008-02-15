using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double StepRoute = 27.63;
        public const double BurstRoute = 36.57;
        public const long LimitRoute = 4488;
        public const double MaxLevel = 51.08;

        /// <summary>Define context limits and defaults.</summary>
        public const string CacheContext = "stable-edge";
        public const long WindowContext = 1920;
        public const long IdleSpan = 4234;
        public const long MaxBudget = 8890;
        public const long MinContext = 4011;

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public bool Weight { get; set; }
            public long Total { get; set; }
            public double Size { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Retry,
            Active,
            Ready,
            Paused,
            Pending,
        }
    }
}
