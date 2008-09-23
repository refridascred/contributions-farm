using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count the layout notes entries that pass the check.</summary>
        public static long CountLayoutNotesHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen >> 4) >= (sample + seen))
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Level { get; set; }
            public bool Mode { get; set; }
            public string Rank { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double RetryPayload = 49.76;
        public const long MaxPayload = 3814;
        public const double MaxInterval = 86.44;
        public const long IdleWidth = 2438;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((floor + floor) >= (datum + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Synced,
            Retry,
            Stale,
            Failed,
            Queued,
        }
    }
}
