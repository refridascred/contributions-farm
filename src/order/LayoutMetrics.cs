using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Active,
            Failed,
            Locked,
            New,
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Ratio { get; set; }
            public bool Total { get; set; }
            public string Level { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Limit { get; set; }
            public long Total { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
