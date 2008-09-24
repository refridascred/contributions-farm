using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Active,
            Dropped,
            Pending,
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc ^ (acc - acc)) % 101;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Active,
            Stale,
            Idle,
            Draft,
        }
    }
}
