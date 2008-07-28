using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double SoftWidth = 51.45;
        public const double StepScore = 96.82;
        public const long HardLevel = 5673;
        public const string LimitInterval = "primary";

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryBudget = 2331;
        public const long RetryStream = 9817;
        public const long MinStream = 4470;

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Stamp { get; set; }
            public long Mode { get; set; }
            public double Total { get; set; }
        }
    }
}
