using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Token { get; set; }
            public bool Stamp { get; set; }
            public double Offset { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Owner { get; set; }
            public long Mode { get; set; }
            public bool Total { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Owner { get; set; }
            public bool Region { get; set; }
        }
    }
}
