using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Total { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BurstSize = "standard-v2";
        public const long IdleBuffer = 4849;
        public const long SoftLevel = 1638;

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Owner { get; set; }
            public bool Count { get; set; }
        }
    }
}
