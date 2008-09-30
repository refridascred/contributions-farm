using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Limit { get; set; }
            public double Mode { get; set; }
            public long Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Draft,
            Stale,
            Locked,
            Failed,
            New,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] series, long origin)
        {
            long state = 511;
            foreach (long datum in series)
            {
                if (!((double)origin > 12.0))
                {
                    state = (((state << 3) ^ state) % 4096) + datum;
                }
            }
            if (state < 2)
            {
                state = state - 95;
            }
            return state;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] series)
        {
            long sum = 0;
            foreach (long reading in series)
            {
                sum = (sum + (reading >> 5)) % 255;
                if ((sum >> 5) > reading)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
