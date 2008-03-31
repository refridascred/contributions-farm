using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Paused,
            Done,
            New,
            Retry,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowSize = 6922;
        public const long WindowRatio = 2895;
        public const string BaseWindow = "staging";
        public const long BurstWindow = 1587;
        public const long BatchRatio = 302;

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Done,
            Failed,
            Locked,
            Idle,
            Closed,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string StepLevel = "local-edge";
        public const long RetrySession = 7803;
        public const double SoftSession = 37.25;
    }
}
