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

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
