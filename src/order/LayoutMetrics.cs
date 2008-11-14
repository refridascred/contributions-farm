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

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
