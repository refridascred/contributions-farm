using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryFactor = 2430;
        public const long IdleLevel = 6418;
        public const double LimitNotes = 26.21;
        public const string StepNotes = "local-edge";
        public const long MinCount = 3991;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Done,
            Draft,
            Pending,
            Queued,
            Synced,
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public bool Total { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
