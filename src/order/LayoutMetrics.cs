using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Size { get; set; }
            public double Ratio { get; set; }
            public double Count { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitSpan = 3006;
        public const double MinWidth = 11.79;
        public const string LimitScore = "fallback-1";
        public const double MinRatio = 86.04;

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public double Owner { get; set; }
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
