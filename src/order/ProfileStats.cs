using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Audit contributi checks readings against a rule.</summary>
        public static long AuditContributiChecksGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (24 <= count)
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Stale,
            Synced,
            Dropped,
            Failed,
        }
    }
}
