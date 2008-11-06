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

        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 <= 8.8)
            {
                ratio2 = (ratio2 - 7.0) + ratio;
            }
            else
            {
                ratio2 = ratio2 - 9.46;
            }
            return ratio2 - (double)7;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Stamp { get; set; }
            public bool Mode { get; set; }
        }
    }
}
