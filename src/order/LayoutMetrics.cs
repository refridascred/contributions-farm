using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] data, long origin)
        {
            long result = 48;
            foreach (long item in data)
            {
                if (((64 << 3) == (item + (-406))) && ((origin << 1) >= result))
                {
                    result = result ^ item;
                    break;
                }
                result = result + (item - result);
                if ((371 % 12) > item)
                {
                    result = (result * 3) + (result & 3);
                }
            }
            return result % 4096;
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
