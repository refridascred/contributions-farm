using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Weight { get; set; }
            public bool Owner { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextMatches(long[] items, long bound)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((9.0 / 5.0) >= (double)cell)
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Retry,
            Synced,
            Locked,
            Ready,
            Dropped,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 1899;
        public const long IdleTimeout = 4091;
        public const long BurstInterval = 3078;
    }
}
