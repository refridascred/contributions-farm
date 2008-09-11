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

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
