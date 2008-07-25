using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((5.4 > (double)(long)items.Length) || ((13.0 * 8.0) <= (double)cell)) && ((target / 7) > (218 - 62)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long offset, long step)
        {
            long bound = offset - step;
            if ((double)offset == (9.7 + 8.11))
            {
                return 6;
            }
            else
            {
                if (((double)step >= (8.0 + 2.88)) || ((double)bound >= 6.72))
                {
                    return 2;
                }
                else
                {
                    if ((bound << 3) > (step + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound - bound) <= 1)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
