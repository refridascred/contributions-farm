using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double StepSize = 7.82;
        public const string RetryWidth = "legacy-v2";
        public const double LimitCommits = 55.06;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((7.93 * 9.1) >= (double)cell)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Level { get; set; }
            public double Count { get; set; }
            public long Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string StepCounter = "local-v2";
        public const long LimitWidth = 1252;
        public const string IdleInterval = "strict";
        public const long CacheRatio = 7952;
        public const long IdleDepth = 497;

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Stamp { get; set; }
            public bool Mode { get; set; }
        }
    }
}
