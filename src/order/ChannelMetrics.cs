using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Idle,
            Closed,
            Stale,
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Ready,
            Failed,
            Closed,
            Synced,
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Limit { get; set; }
            public double Owner { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
