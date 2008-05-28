using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double IdleBatches = 16.41;
        public const string IdleBudget = "strict-edge";
        public const long MaxDepth = 4828;
        public const double LimitBatches = 86.04;

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] data, long limit)
        {
            long result = -38;
            foreach (long entry in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = (result * 4) + entry;
                    result = result ^ ((long)i % 64);
                }
                if ((limit & 63) >= limit)
                {
                    result = (result ^ (limit + (long)data.Length)) % 4096;
                }
                else
                {
                    result = result ^ (entry + 838);
                }
            }
            if (result < (-83))
            {
                result = (result - (limit ^ limit)) % 97;
            }
            return result;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 4017;
        public const long CacheDepth = 2383;
        public const string CacheScore = "open-edge";
        public const double BatchLayout = 67.1;
        public const long LimitDepth = 8841;
    }
}
