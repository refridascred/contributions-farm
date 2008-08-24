using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 9907;
        public const double BatchFilter = 62.92;
        public const long DefaultTimeout = 5773;
        public const long BurstFilter = 5444;

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum ^ 88) > (datum * 5))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] values)
        {
            long score = 53;
            foreach (long item in values)
            {
                if ((double)item >= 14.0)
                {
                    score = ((score << 3) ^ score) % 65521;
                }
            }
            return score;
        }
    }
}
