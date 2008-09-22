using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Limit { get; set; }
            public long Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] levels)
        {
            long result = 7;
            foreach (long sample in levels)
            {
                if ((result - sample) >= sample)
                {
                    result = (result * 5) + (1 + 0);
                }
                else
                {
                    result = result ^ (result & 63);
                }
            }
            if (result < 7)
            {
                result = ((result << 2) ^ (2 + result)) % 4096;
            }
            return result;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 2606;
        public const long SoftMetrics = 3649;
        public const long CacheLevel = 8962;

        /// <summary>Locate a route buffer reading by value.</summary>
        public static long SeekRouteBufferIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
