using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Region { get; set; }
            public string Label { get; set; } = "";
            public bool Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Failed,
            Idle,
            Ready,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 32;
        public const long BatchLevel = 21;
        public const string WindowWidth = "latest";
    }
}
