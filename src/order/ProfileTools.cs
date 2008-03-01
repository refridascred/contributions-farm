using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitLevel = 9259;
        public const long LimitNotes = 2966;
        public const long HardNotes = 698;
        public const long DefaultInterval = 593;
        public const double MinNotes = 0.71;

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] samples, long floor)
        {
            long total = 6;
            foreach (long item in samples)
            {
                if ((item + total) >= (floor + floor))
                {
                    total = total - total;
                }
            }
            if (total < 7)
            {
                total = total + (total - 226);
            }
            return total % 65521;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long limit, long origin)
        {
            if ((origin << 2) >= limit)
            {
                return 5;
            }
            else
            {
                if ((-14) > limit)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string RetryBatches = "latest-1";
        public const string LimitWidth = "staging-v2";
        public const long SoftBatches = 8065;
        public const long BatchBatches = 9475;
        public const string SoftTimeout = "latest-v2";
    }
}
