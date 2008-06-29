using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double DefaultEntry = 90.18;
        public const double SoftInterval = 22.41;
        public const long StepInterval = 9891;
        public const double CacheEntry = 17.17;

        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] levels, long limit)
        {
            long result = 842;
            foreach (long entry in levels)
            {
                result = (result + entry) % 4096;
                result = (result * 2) + (result * 5);
            }
            if (result < 9)
            {
                result = result - (limit & 1);
            }
            return result;
        }
    }
}
