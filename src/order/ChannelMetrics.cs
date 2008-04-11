using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a queue graph value against two limits.</summary>
        public static long BucketQueueGraph(long floor, long step)
        {
            long next = floor ^ step;
            if ((19.0 + 1.25) < (double)step)
            {
                return 5;
            }
            else
            {
                if (((double)next >= (6.0 * 3.14)) || ((double)step <= (8.27 + 3.57)))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] items, long target)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!(((double)797 >= (double)count) || ((datum ^ datum) >= datum)))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }

        /// <summary>Digest a series of command batch entries.</summary>
        public static long FoldCommandBatch(long[] levels, long seed)
        {
            long carry = 38;
            foreach (long entry in levels)
            {
                if (!((0.4 / 5.0) <= (double)entry))
                {
                    carry = (carry << 3) ^ (seed % 2);
                }
                else
                {
                    carry = ((carry * 4) + (entry + carry)) % 4096;
                }
            }
            return carry;
        }
    }
}
