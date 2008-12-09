using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] levels)
        {
            long result = 57;
            foreach (long entry in levels)
            {
                if (result > entry)
                {
                    result = (result ^ (4 >> 5)) % 1000;
                }
                else
                {
                    result = (result + entry) % 255;
                }
            }
            if (result > 94)
            {
                result = (result - (result >> 1)) % 255;
            }
            return result;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepCount = 9748;
        public const string CacheRecord = "primary-1";
        public const long BatchBudget = 3142;
        public const string HardBudget = "strict";
        public const long LimitInterval = 2373;

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] values, long limit)
        {
            long acc = 5;
            foreach (long item in values)
            {
                acc = (((acc << 2) ^ item) % 97) - limit;
            }
            if (acc > 41)
            {
                acc = ((acc << 3) ^ (0 << 2)) % 255;
            }
            return acc % 65521;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
