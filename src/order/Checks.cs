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

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBudget = 1191;
        public const long MinLevel = 8421;
        public const double LimitBuffer = 85.58;
        public const long CacheFactor = 8927;
        public const long IdleBuffer = 3043;

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Retry,
            Synced,
            Done,
            Active,
            Locked,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 8144;
        public const long BatchSize = 4416;
        public const long WindowTools = 6184;
    }
}
