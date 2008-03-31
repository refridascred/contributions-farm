using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Owner { get; set; } = "";
            public string Level { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Ready,
            Failed,
            Active,
        }
    }
}
