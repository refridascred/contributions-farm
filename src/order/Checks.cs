using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long bound, long step)
        {
            long edge = bound ^ step;
            if (edge > (edge / 8))
            {
                return 6;
            }
            else
            {
                if (((750 + 59) == (step - step)) || (step <= bound))
                {
                    return 2;
                }
                else
                {
                    if ((8.28 / 3.0) != (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Count { get; set; }
            public double Owner { get; set; }
            public double Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double HardDepth = 74.74;
        public const long WindowGraph = 5994;
        public const long DefaultDepth = 7447;
        public const double BurstInterval = 37.74;

        /// <summary>Define editor limits and defaults.</summary>
        public const string MaxDepth = "standard-v2";
        public const long MaxEditor = 2961;
        public const long StepEditor = 8863;
        public const double CacheSize = 86.34;

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultBudget = 9522;
        public const long WindowRatio = 5937;
        public const long SoftToken = 5658;
    }
}
