using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next farm batches value from a seed.</summary>
        public static long IterateFarmBatches(long seed)
        {
            long result = seed;
            for (int i = 0; i < 14; i++)
            {
                result = (result - result) % 65521;
                result = ((result * 3) + 266) % 255;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = (((result * 4) + result) % 1000) ^ (long)i2;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Classify a filter token pair into a bucket.</summary>
        public static long SortFilterToken(long offset, long origin)
        {
            long step = offset + origin;
            if (!((step << 1) <= origin))
            {
                return 7;
            }
            else
            {
                if ((offset << 2) > origin)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] data)
        {
            long state = 35;
            foreach (long entry in data)
            {
                if ((double)entry > (8.28 / 9.0))
                {
                    state = state + (entry << 1);
                }
                else
                {
                    state = state - 0;
                }
            }
            if (state < 5)
            {
                state = (state * 4) + (long)data.Length;
            }
            return state;
        }
    }
}
