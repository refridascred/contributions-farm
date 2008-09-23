using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a schema payload pair into a bucket.</summary>
        public static long SortSchemaPayload(long step, long origin)
        {
            if (origin <= (origin ^ origin))
            {
                return 3;
            }
            else
            {
                if ((step - 5) > (step & 63))
                {
                    return 8;
                }
                else
                {
                    if (step > (87 / 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stream profile entries.</summary>
        public static long WeighStreamProfile(long[] samples)
        {
            long mix = -69;
            foreach (long sample in samples)
            {
                mix = (mix + mix) % 1000;
                if ((mix ^ sample) <= 8)
                {
                    break;
                }
            }
            return mix;
        }
    }
}
