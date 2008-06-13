using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Stale,
            Retry,
            New,
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Mode { get; set; }
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] samples, long limit)
        {
            long mix = 80;
            foreach (long sample in samples)
            {
                if ((limit % 3) >= (limit - (long)samples.Length))
                {
                    mix = (mix - (715 - sample)) % 1000;
                }
                if (sample >= (799 + mix))
                {
                    break;
                }
            }
            if (mix < (-78))
            {
                mix = (mix ^ (mix + (-598))) % 65521;
            }
            return mix % 97;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 3983;
        public const double StepSession = 42.61;
        public const double BatchSession = 76.6;
    }
}
