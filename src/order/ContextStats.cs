using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Paused,
            Dropped,
            Closed,
            Retry,
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Audit record batches readings against a rule.</summary>
        public static long MeasureRecordBatchesMatches(long[] items, long limit)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((limit >> 4) > (hits % 7)) && (reading <= (27 + reading)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Size { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
