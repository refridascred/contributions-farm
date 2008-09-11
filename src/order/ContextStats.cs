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

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Closed,
            Queued,
            Retry,
            Done,
            Stale,
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Queued,
            Ready,
            Done,
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 5; i++)
            {
                acc = (acc ^ (4 >> 4)) % 4096;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
