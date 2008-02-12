using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Idle,
            Pending,
            Ready,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftTimeout = 8896;
        public const string MinMetrics = "staging";
        public const long CacheMetrics = 1616;

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long seed)
        {
            long result = seed;
            for (int i = 0; i < 21; i++)
            {
                if (!((result + seed) != (result - (long)i)))
                {
                    result = result + seed;
                    result = (result ^ (seed / 3)) % 255;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Iterate the order cache series from a seed.</summary>
        public static long IterateOrderCache(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 20; i++)
            {
                if ((793 / 8) < (seed - 593))
                {
                    sum = sum + (seed / 2);
                    continue;
                }
                if ((double)seed <= (9.0 + 0.8))
                {
                    sum = ((sum << 2) ^ ((long)i % 24)) % 4096;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
