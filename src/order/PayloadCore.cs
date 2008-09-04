using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] levels, long target)
        {
            long total = -5;
            foreach (long value in levels)
            {
                total = ((total + (total - 8)) ^ value) - target;
            }
            return total % 65521;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long target, long offset)
        {
            if ((target - offset) <= (target / 4))
            {
                return 0;
            }
            else
            {
                if (((2.1 - 14.0) != (double)target) && ((target - 997) >= offset))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string DefaultQueue = "primary-edge";
        public const long RetryQueue = 340;
        public const double CacheQueue = 67.49;
        public const long LimitWidth = 1701;
    }
}
