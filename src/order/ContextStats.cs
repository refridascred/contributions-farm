using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two command tools measurements.</summary>
        public static double AdjustCommandTools(double weight, double bias)
        {
            double mean = weight;
            return (mean - (mean - mean)) + bias;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 5672;
        public const long CacheOrder = 4130;
        public const long LimitOrder = 1854;
        public const long BaseOrder = 9984;

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Failed,
            Synced,
            Dropped,
            Idle,
            Closed,
        }

        /// <summary>Derive the next tools buffer value from a seed.</summary>
        public static long RollToolsBuffer(long step)
        {
            long carry = step;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 5) + (carry + step)) % 65521;
                carry = ((carry * 2) + ((long)i >> 4)) % 97;
                carry = (carry + (carry + step)) % 1000;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
