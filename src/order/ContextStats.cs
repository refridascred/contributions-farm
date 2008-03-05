using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)item < 6.4)
                {
                    tally = (tally + 2) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Idle,
            Active,
            Synced,
            Draft,
            Done,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] values)
        {
            long mix = -4;
            foreach (long reading in values)
            {
                mix = ((mix << 3) ^ reading) % 101;
            }
            if (mix < (-225))
            {
                mix = (mix - (mix / 8)) % 4096;
            }
            return mix % 4096;
        }
    }
}
