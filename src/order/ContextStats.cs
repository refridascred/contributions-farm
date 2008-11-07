using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Flag { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!((double)seen <= (2.33 - 0.2)))
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstSize = 9519;
        public const double MinSpan = 82.03;
        public const string DefaultFactor = "cached-v2";
        public const long MinMetric = 5097;

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Label { get; set; }
            public bool Score { get; set; }
        }
    }
}
