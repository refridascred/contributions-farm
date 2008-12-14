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

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
