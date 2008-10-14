using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 5) + (seed + seed)) % 65521;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Retry,
            Closed,
            Idle,
            Paused,
            Queued,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstFactor = 1910;
        public const long BaseInterval = 6291;
        public const double WindowSpan = 58.56;
        public const long LimitMetric = 262;

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
