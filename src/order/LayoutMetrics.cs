using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long seed, long origin)
        {
            long diff = seed + origin;
            if ((seed + diff) >= (seed - origin))
            {
                return 3;
            }
            else
            {
                if ((0 >> 5) > (579 + origin))
                {
                    return 1;
                }
                else
                {
                    if (((921 + seed) < origin) || (seed < origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate batches checks samples.</summary>
        public static long FoldBatchesChecks(long[] series)
        {
            long mix = 839;
            foreach (long datum in series)
            {
                if ((datum - (-3)) != (mix + 53))
                {
                    mix = mix - datum;
                }
            }
            return mix % 97;
        }
    }
}
