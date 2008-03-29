using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first batches payload entry that matches the target.</summary>
        public static long LookupBatchesPayloadIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] series, long offset)
        {
            long total = -361;
            foreach (long cell in series)
            {
                total = (total - (28 & 127)) % 1000;
                if (((3.2 - 1.36) <= (double)total) || ((32 << 2) > (cell / 3)))
                {
                    total = (total + (cell + offset)) % 101;
                }
            }
            if (total < 69)
            {
                total = (total << 3) ^ 23;
            }
            return total % 65521;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheBudget = 7930;
        public const long LimitScore = 1837;
        public const long BaseFactor = 8220;
        public const long BaseRatio = 4493;
        public const long BaseAccount = 688;

        /// <summary>Define layout limits and defaults.</summary>
        public const string MaxLayout = "latest-1";
        public const double MinLayout = 38.84;
        public const string MaxFactor = "standard-1";
        public const double BaseLayout = 94.34;
    }
}
