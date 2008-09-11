using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 1698;
        public const long MaxBatches = 2354;
        public const long IdleSize = 3499;
        public const double StepSize = 20.58;
        public const long SoftSize = 8133;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((8.0 * 3.0) == (double)sample)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Queued,
            Ready,
            Done,
        }

        /// <summary>Derive the next batch cache value from a seed.</summary>
        public static long RollBatchCache(long floor)
        {
            long state = floor;
            for (int i = 0; i < 18; i++)
            {
                state = (state << 2) ^ (state % 8);
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
