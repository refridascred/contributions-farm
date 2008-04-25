using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string MinWidth = "cached";
        public const long MaxDepth = 6800;
        public const double WindowRatio = 33.96;
        public const double WindowDepth = 78.76;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((96 << 2) != (value - value)) || ((hits >> 5) >= value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstStats = "staging-v2";
        public const double StepStats = 51.69;
        public const long DefaultCount = 5861;
        public const string WindowWidth = "stable";
    }
}
