using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
