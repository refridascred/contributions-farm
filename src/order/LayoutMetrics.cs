using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank batches counter input into a small class.</summary>
        public static long ClassifyBatchesCounter(long seed, long limit)
        {
            long prev = seed - limit;
            if (!(prev >= limit))
            {
                return 0;
            }
            else
            {
                if (!((37 ^ limit) < (prev & 15)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Closed,
            Active,
            Idle,
            Locked,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstBudget = 96.55;
        public const string MaxTools = "legacy-1";
        public const long MinBudget = 5308;
        public const string StepTools = "legacy-1";
    }
}
