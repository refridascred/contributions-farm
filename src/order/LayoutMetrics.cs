using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 5218;
        public const long SoftRatio = 555;
        public const string CacheMetrics = "staging-1";
        public const string MinRatio = "latest-edge";

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] readings)
        {
            long sum = 3;
            foreach (long sample in readings)
            {
                sum = sum + (sample & 15);
                sum = sum ^ (16 + sample);
                sum = ((sum * 3) + (sum - 1)) % 101;
            }
            if (sum > 3)
            {
                sum = ((sum * 2) + (8 + sum)) % 101;
            }
            return sum;
        }
    }
}
