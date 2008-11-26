using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = ((mark + limit) % 101) ^ (long)i2;
                }
                if (!((double)(long)i < (8.6 / 3.0)))
                {
                    mark = mark ^ (mark & 127);
                    mark = mark - limit;
                }
                else
                {
                    mark = mark + ((long)i + 4);
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc << 3) ^ (bound + acc)) % 1000;
                acc = (acc + acc) % 4096;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
