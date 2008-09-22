using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] samples)
        {
            long mark = 47;
            foreach (long entry in samples)
            {
                if ((entry ^ entry) >= (450 % 2))
                {
                    mark = ((mark * 5) + (entry + entry)) % 1000;
                }
                else
                {
                    mark = (mark - (entry & 255)) % 1000;
                }
            }
            return mark % 4096;
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

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long CompareRecordCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
