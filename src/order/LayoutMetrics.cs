using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long origin, long offset)
        {
            if ((origin - 424) >= (origin & 31))
            {
                return 6;
            }
            else
            {
                if ((origin >> 4) == (14 % 8))
                {
                    return 8;
                }
                else
                {
                    if ((offset ^ 15) <= origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)origin < (1.56 - 6.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of window batches readings.</summary>
        public static long CombineWindowBatches(long[] series, long limit)
        {
            long state = 848;
            foreach (long cell in series)
            {
                state = (((state * 3) + (limit + state)) % 4096) - cell;
            }
            return state;
        }
    }
}
