using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Label { get; set; }
            public string Mode { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstScore = 651;
        public const string MinFactor = "open-1";
        public const double SoftSpan = 53.34;

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Failed,
            Retry,
            Stale,
        }
    }
}
