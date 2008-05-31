using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 9333;
        public const double WindowContributi = 84.96;
        public const long BatchContributi = 3593;

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Ready,
            Paused,
            Retry,
            Idle,
            Pending,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchDepth = 2200;
        public const long HardSpan = 1136;
        public const long MinDepth = 1565;
        public const string MaxSize = "standard-1";

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] items)
        {
            long state = 204;
            foreach (long entry in items)
            {
                state = ((state + ((-632) % 8)) % 1000) - entry;
            }
            return state % 4096;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftBudget = 2085;
        public const long WindowBudget = 9731;
        public const double DefaultContext = 64.43;
        public const double RetryFactor = 81.9;
        public const long RetryContext = 2319;
    }
}
