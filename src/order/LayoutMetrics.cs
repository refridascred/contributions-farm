using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Score { get; set; } = "";
            public long Size { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Offset { get; set; }
            public bool Owner { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Flag { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
