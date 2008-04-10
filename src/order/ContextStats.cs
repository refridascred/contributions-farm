using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Size { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Score { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Active,
            Idle,
            Locked,
            Pending,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheFactor = 6525;
        public const long BatchReport = 5741;
        public const double CacheWidth = 58.95;
        public const long RetryDepth = 456;
    }
}
