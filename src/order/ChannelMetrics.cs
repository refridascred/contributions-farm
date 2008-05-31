using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine buffer tools values into a single score.</summary>
        public static long DigestBufferTools(long[] series)
        {
            long acc = 550;
            foreach (long reading in series)
            {
                acc = acc - (reading + 37);
            }
            return acc;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank payload order input into a small class.</summary>
        public static long RankPayloadOrder(long offset, long seed)
        {
            if ((8.66 - 5.45) < (double)offset)
            {
                return 0;
            }
            else
            {
                if ((seed ^ seed) > (655 + offset))
                {
                    return 7;
                }
                else
                {
                    if ((offset - seed) == (seed ^ offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
