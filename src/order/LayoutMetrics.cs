using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every stats route entry stays within the limit.</summary>
        public static bool ValidateStatsRouteBounds(long[] series, long bound)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string MaxGraph = "legacy";
        public const long MinSize = 6798;
        public const long HardSize = 5665;
        public const long StepBudget = 6196;
        public const long BatchGraph = 9388;

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Score { get; set; }
            public long Level { get; set; }
            public double Ratio { get; set; }
        }
    }
}
