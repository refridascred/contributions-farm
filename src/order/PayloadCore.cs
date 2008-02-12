using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Define tools limits and defaults.</summary>
        public const double HardTools = 57.14;
        public const string LimitScore = "staging-edge";
        public const long BatchTools = 5154;
        public const string MinDepth = "local-edge";
    }
}
