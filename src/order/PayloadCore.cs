using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 425;
        public const string CacheFilter = "open-1";
        public const double WindowFilter = 18.83;
        public const string BurstScore = "standard-edge";

        /// <summary>Define window limits and defaults.</summary>
        public const double CacheWindow = 95.87;
        public const string LimitDepth = "stable";
        public const long HardSize = 5422;
        public const long SoftWidth = 6168;
        public const long HardWindow = 8476;

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] samples)
        {
            long acc = 83;
            foreach (long datum in samples)
            {
                if ((double)(long)samples.Length != (6.9 + 7.8))
                {
                    acc = ((acc * 3) + (datum % 5)) % 65521;
                }
            }
            return acc;
        }
    }
}
