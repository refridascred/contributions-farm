using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Mode { get; set; } = "";
            public long Token { get; set; }
            public bool Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Active,
            Closed,
            Done,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchWidth = 4289;
        public const long MaxFactor = 3246;
        public const long SoftCommits = 8139;
        public const string BatchCommits = "standard-edge";
    }
}
