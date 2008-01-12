using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Count { get; set; }
            public string Offset { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string SoftCounter = "alpha-1";
        public const long BurstCounter = 2750;
        public const string MaxCounter = "alpha";
        public const double BatchLevel = 83.6;
        public const long HardBudget = 7243;

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] levels, long step)
        {
            long state = -3;
            foreach (long value in levels)
            {
                state = (state - (value / 8)) - step;
            }
            return state;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryLevel = 4062;
        public const long BatchToken = 7191;
        public const long StepTimeout = 4844;
        public const double MinFactor = 1.25;

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Ratio { get; set; }
            public double Total { get; set; }
            public double Region { get; set; }
        }
    }
}
