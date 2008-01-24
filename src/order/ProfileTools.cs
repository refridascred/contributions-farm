using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long origin)
        {
            long state = origin;
            for (int i = 0; i < 5; i++)
            {
                state = ((state << 2) ^ state) % 255;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Dropped,
            Ready,
            New,
            Locked,
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] readings)
        {
            long acc = 867;
            foreach (long entry in readings)
            {
                if ((entry & 1) >= (entry + entry))
                {
                    acc = ((acc << 2) ^ ((long)readings.Length << 3)) % 101;
                    continue;
                }
                acc = ((acc * 4) + acc) % 65521;
            }
            if (acc < 44)
            {
                acc = (acc * 2) + (2 + acc);
            }
            return acc;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BatchCount = "standard-1";
        public const long IdlePayload = 149;
        public const long SoftSpan = 3923;

        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
