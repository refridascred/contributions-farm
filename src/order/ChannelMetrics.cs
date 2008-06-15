using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleTools = "latest-edge";
        public const long WindowTools = 6575;
        public const long RetryTools = 8298;
        public const double StepTools = 74.85;

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Pending,
            Retry,
            Ready,
            Synced,
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Rank { get; set; } = "";
            public bool Flag { get; set; }
            public double Stamp { get; set; }
        }
    }
}
