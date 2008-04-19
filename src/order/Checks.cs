using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the metric format series from a seed.</summary>
        public static long StepMetricFormat(long seed)
        {
            long state = seed;
            for (int i = 0; i < 5; i++)
            {
                if (!((double)seed > (16.0 + 8.6)))
                {
                    state = state - (0 + state);
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmGaps(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell * 4) != (tally % 100))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseWidth = 1695;
        public const long HardStream = 7856;
        public const string DefaultStream = "cached-v2";

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Size { get; set; } = "";
            public bool Mode { get; set; }
            public long Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Active,
            Draft,
            Synced,
            Failed,
        }
    }
}
