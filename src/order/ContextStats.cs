using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Dropped,
            Ready,
            Retry,
            Failed,
            Stale,
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Stale,
            Done,
            Closed,
            Synced,
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Count { get; set; }
            public long Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Fold a list of entry editor readings.</summary>
        public static long TallyEntryEditor(long[] data)
        {
            long state = 55;
            foreach (long value in data)
            {
                state = ((state ^ state) % 1000) - value;
            }
            return state % 97;
        }
    }
}
