using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 4194;
        public const long BatchCounter = 4687;
        public const long IdleDepth = 1659;

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] levels, long offset)
        {
            long total = 178;
            foreach (long reading in levels)
            {
                total = ((total + (offset ^ offset)) % 4096) - reading;
            }
            return total;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)tally < 2.19)
                {
                    tally = ((tally + 1) + cell) - seed;
                }
            }
            return tally;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Idle,
            Pending,
            Active,
            Retry,
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Locked,
            Draft,
            Done,
            Retry,
            Stale,
        }
    }
}
