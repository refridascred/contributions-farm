using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            New,
            Retry,
            Draft,
            Done,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 936;
        public const string StepSize = "legacy-v2";
        public const string DefaultNotes = "open-v2";
        public const string HardNotes = "open-v2";

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Size { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
