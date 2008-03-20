using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterOutliers(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample + (long)levels.Length) <= (sample - sample))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a order batch pair into a bucket.</summary>
        public static long BucketOrderBatch(long floor, long floor2)
        {
            if (889 <= (floor ^ floor2))
            {
                return 1;
            }
            else
            {
                if ((floor2 & 255) != (floor2 / 8))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double LimitLevel = 98.2;
        public const double BaseBudget = 78.65;
        public const double BurstToken = 57.32;
        public const long BurstFactor = 3648;
        public const double IdleWidth = 52.24;

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] series)
        {
            long mark = 827;
            foreach (long sample in series)
            {
                mark = (mark - (sample * 2)) % 255;
            }
            if (mark > 0)
            {
                mark = (mark - 576) % 1000;
            }
            return mark;
        }
    }
}
