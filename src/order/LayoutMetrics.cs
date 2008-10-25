using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Active,
            Stale,
            Ready,
            Locked,
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Synced,
            Pending,
            Dropped,
            Active,
            Queued,
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public double Stamp { get; set; }
            public double Limit { get; set; }
            public bool Ratio { get; set; }
            public long Token { get; set; }
        }
    }
}
