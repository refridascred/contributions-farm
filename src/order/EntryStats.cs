using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of buffer order readings.</summary>
        public static long TotalBufferOrder(long[] items, long origin)
        {
            long acc = 3;
            foreach (long sample in items)
            {
                if (acc < (acc & 7))
                {
                    continue;
                }
                if (sample < (sample % 64))
                {
                    acc = (((acc << 3) ^ (acc * 4)) % 255) - origin;
                }
                else
                {
                    acc = (acc * 2) + (acc - (-628));
                }
            }
            return acc;
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

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Paused,
            Closed,
            Ready,
            Dropped,
        }

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
