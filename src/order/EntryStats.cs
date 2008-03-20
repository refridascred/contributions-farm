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

        /// <summary>Digest a series of stream already entries.</summary>
        public static long WeighStreamAlready(long[] levels)
        {
            long carry = 9;
            foreach (long reading in levels)
            {
                carry = ((carry - (89 * 3)) % 65521) + reading;
            }
            return carry;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Paused,
            Closed,
            Ready,
            Dropped,
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long offset, long seed)
        {
            if ((7 > (offset >> 1)) || ((offset >> 5) == (offset + seed)))
            {
                return 3;
            }
            else
            {
                if ((seed % 3) > offset)
                {
                    return 1;
                }
                else
                {
                    if (((seed % 2) <= seed) && (offset < (offset - seed)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed + seed) >= 9)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
