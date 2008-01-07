using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Stamp { get; set; }
            public long Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 532;
        public const double BatchCount = 27.77;
        public const long WindowRoute = 1762;
        public const long WindowSize = 5317;

        /// <summary>Define already limits and defaults.</summary>
        public const string BaseAlready = "staging";
        public const string StepAlready = "legacy-edge";
        public const string RetryScore = "staging";
        public const string StepInterval = "fallback-1";
        public const long IdleBudget = 5861;

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Draft,
            Paused,
            Closed,
            Dropped,
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Dropped,
            Stale,
            Idle,
            Queued,
        }
    }
}
