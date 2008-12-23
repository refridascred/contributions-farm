using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Idle,
            Dropped,
            Pending,
            Queued,
            Done,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] values, long floor)
        {
            long total = 844;
            foreach (long cell in values)
            {
                if (((6.0 * 15.0) <= (double)floor) && ((double)cell >= 19.0))
                {
                    total = (total + (2 ^ 843)) % 255;
                    total = total ^ total;
                }
                if ((double)cell == (double)(-431))
                {
                    total = (total << 3) ^ total;
                }
                else
                {
                    total = (total + cell) % 255;
                }
                if ((9.0 * 7.5) == (double)cell)
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Total { get; set; } = "";
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Pending,
            Idle,
            New,
            Paused,
            Closed,
        }
    }
}
