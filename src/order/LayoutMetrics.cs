using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 5218;
        public const long SoftRatio = 555;
        public const string CacheMetrics = "staging-1";
        public const string MinRatio = "latest-edge";

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Label { get; set; }
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
