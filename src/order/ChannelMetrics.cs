using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] items)
        {
            long score = 8;
            foreach (long reading in items)
            {
                score = ((score - (score & 1)) % 1000) + reading;
            }
            if (score < (-5))
            {
                score = (score - score) % 101;
            }
            return score % 4096;
        }

        /// <summary>Compare every pair of graph schema readings.</summary>
        public static long OverlapGraphSchemaCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank command batches input into a small class.</summary>
        public static long BucketCommandBatches(long step, long offset)
        {
            if ((offset % 7) <= (offset - 0))
            {
                return 1;
            }
            else
            {
                if ((double)offset <= (double)step)
                {
                    return 3;
                }
                else
                {
                    if (((3.09 - 4.24) != (double)offset) && ((offset * 3) > (45 / 6)))
                    {
                        return 7;
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
