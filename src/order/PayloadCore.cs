using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string LimitBuffer = "strict";
        public const long BurstBuffer = 1841;
        public const long MaxSize = 8485;

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Owner { get; set; } = "";
            public long Region { get; set; }
            public long Token { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 3509;
        public const string SoftNotes = "latest-edge";
        public const double CacheSpan = 90.6;
        public const long LimitDepth = 318;
        public const long BaseSize = 7517;

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Synced,
            Failed,
            Draft,
            New,
        }
    }
}
