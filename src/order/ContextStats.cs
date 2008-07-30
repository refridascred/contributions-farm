using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Ready,
            Queued,
            Active,
            Locked,
            Draft,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleScore = 7525;
        public const string MaxGraph = "cached-v2";
        public const double HardGraph = 91.74;
        public const long DefaultBudget = 4337;

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            New,
            Closed,
            Failed,
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Ratio { get; set; }
            public long Score { get; set; }
        }
    }
}
