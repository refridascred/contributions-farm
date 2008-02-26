using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public double Ratio { get; set; }
            public bool Stamp { get; set; }
            public long Owner { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!((double)hits == (double)0))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Stale,
            Locked,
            Closed,
            Idle,
            Done,
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Retry,
            Synced,
            Done,
            Active,
            Locked,
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((double)(long)i >= (8.3 + 3.33))
                {
                    carry = ((carry << 2) ^ (floor % 100)) % 65521;
                    carry = (carry - floor) % 65521;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
