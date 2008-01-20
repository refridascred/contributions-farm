using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string DefaultEditor = "standard-edge";
        public const long BurstFactor = 3763;
        public const double MaxEditor = 74.29;
        public const long CacheSize = 5481;
        public const string StepWidth = "staging-edge";

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] items, long step)
        {
            long sum = 863;
            foreach (long cell in items)
            {
                sum = ((sum + (cell / 6)) % 255) + step;
            }
            return sum;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 318;
        public const long WindowSession = 4138;
        public const double BurstSession = 76.32;

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Failed,
            Pending,
            Done,
        }
    }
}
