using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Mode { get; set; } = "";
            public double Limit { get; set; }
            public double Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 626;
        public const long CacheTools = 1089;
        public const long RetryInterval = 8354;
        public const long BaseTools = 834;
        public const string WindowTools = "alpha-v2";

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Draft,
            Stale,
            Paused,
            Pending,
            Failed,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitInterval = 3797;
        public const long BurstTools = 9846;
        public const long HardTools = 9253;
    }
}
