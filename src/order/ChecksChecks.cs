using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Queued,
            Idle,
            Draft,
            Active,
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            New,
            Closed,
            Failed,
            Synced,
            Queued,
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Offset { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
