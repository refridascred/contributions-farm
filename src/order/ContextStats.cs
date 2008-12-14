using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long HardDepth = 2353;
        public const long SoftCount = 1827;
        public const string CacheBudget = "standard-v2";
        public const double StepGraph = 49.07;

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell ^ count) < (cell >> 3))
                {
                    count = (count + 2) + seed;
                }
            }
            return count;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] values)
        {
            long state = 61;
            foreach (long item in values)
            {
                if ((state < (long)values.Length) && (item <= (state * 4)))
                {
                    state = state - item;
                }
            }
            return state;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Count { get; set; }
            public double Size { get; set; }
            public long Level { get; set; }
        }
    }
}
