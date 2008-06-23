using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Token { get; set; }
            public bool Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Flag { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Ready,
            Pending,
            Locked,
            Active,
            Paused,
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }
    }
}
