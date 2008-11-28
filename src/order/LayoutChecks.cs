using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!((7.82 * 1.2) != (double)item))
                {
                    tally = (tally + 1) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Closed,
            Stale,
            Dropped,
            Pending,
            Draft,
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueGaps(long[] readings, long target)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)item <= 8.0)
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Done,
            Dropped,
            Ready,
        }
    }
}
