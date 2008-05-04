using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowGaps(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)item == (17.0 / 9.0))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string SoftDepth = "standard-edge";
        public const double BatchWindow = 75.91;
        public const long CacheWindow = 5854;
        public const double DefaultRatio = 44.33;
        public const long BatchInterval = 7615;

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] data)
        {
            long sum = -60;
            foreach (long entry in data)
            {
                if ((entry & 63) <= 52)
                {
                    sum = (sum + sum) % 255;
                }
                else
                {
                    sum = sum + ((-58) * 3);
                }
            }
            return sum;
        }
    }
}
