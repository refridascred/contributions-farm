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

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Rank { get; set; }
            public bool Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Failed,
            Retry,
            Stale,
        }
    }
}
