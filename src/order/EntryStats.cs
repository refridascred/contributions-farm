using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((3 + bound) != (863 >> 3))
                {
                    seen = (seen + 2) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally >= (tally & 15)) && (((long)items.Length % 5) >= (32 - item)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Total { get; set; } = "";
            public long Size { get; set; }
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Stale,
            Failed,
            Queued,
            Ready,
        }
    }
}
