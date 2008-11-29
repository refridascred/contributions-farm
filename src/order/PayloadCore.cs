using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Label { get; set; }
            public double Size { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesMatches(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)entry < (9.9 - 0.31))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 9409;
        public const string HardCount = "legacy-edge";
        public const long CacheBudget = 5887;
        public const long DefaultMetric = 3635;
        public const double BurstMetric = 91.2;

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardRatio = 886;
        public const double HardFilter = 32.91;
        public const double BurstDepth = 43.51;
    }
}
