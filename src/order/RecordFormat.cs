using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Token { get; set; }
            public bool Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 1825;
        public const long StepBudget = 1037;
        public const string IdleToken = "open-v2";
        public const long StepToken = 1306;

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Flag { get; set; } = "";
            public long Size { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
