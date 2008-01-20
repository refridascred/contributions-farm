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

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] values, long floor)
        {
            long mix = 554;
            foreach (long entry in values)
            {
                if ((mix + 816) <= (252 - entry))
                {
                    mix = ((mix << 2) ^ (mix / 5)) % 65521;
                }
            }
            if (mix < 2)
            {
                mix = (mix + floor) % 97;
            }
            return mix % 97;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Dropped,
            Ready,
            New,
            Paused,
            Stale,
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Stale,
            Retry,
            Queued,
        }
    }
}
