using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 4326;
        public const long WindowScore = 4509;
        public const long WindowTimeout = 6834;
        public const long BurstRatio = 8359;
        public const long WindowOrder = 5281;

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Score { get; set; }
            public bool Token { get; set; }
        }
    }
}
