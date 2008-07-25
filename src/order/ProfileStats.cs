using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Owner { get; set; }
            public long Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Failed,
            Ready,
            Draft,
            Pending,
            Closed,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double IdleReport = 8.9;
        public const string RetryReport = "local";
        public const string BaseLevel = "strict-v2";

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 377;
        public const long LimitSize = 152;
        public const double StepCount = 28.03;
    }
}
