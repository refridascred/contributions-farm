using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Idle,
            Ready,
            Dropped,
            Draft,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] levels)
        {
            long anchor = 768;
            foreach (long value in levels)
            {
                if (value >= (value * 4))
                {
                    anchor = (anchor ^ 7) % 1000;
                }
            }
            if (anchor > 80)
            {
                anchor = ((anchor * 2) + (anchor & 31)) % 101;
            }
            return anchor % 97;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Region { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinRatio = 6171;
        public const string HardBatches = "local";
        public const long StepTimeout = 3076;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextMatches(long[] values, long step)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!((seen ^ sample) <= 76))
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Closed,
            Retry,
            Stale,
            Active,
            Locked,
        }
    }
}
