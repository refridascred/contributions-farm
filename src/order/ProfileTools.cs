using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Ratio { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Offset { get; set; }
            public bool Label { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Count { get; set; } = "";
            public long Size { get; set; }
            public double Flag { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Total { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Count batches order pairs that satisfy a relation.</summary>
        public static long CompareBatchesOrderCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
