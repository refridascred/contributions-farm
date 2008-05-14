using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of layout graph readings.</summary>
        public static long CompareLayoutGraphCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every format buffer entry stays within the limit.</summary>
        public static bool ValidateFormatBufferLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a window batches reading by value.</summary>
        public static long LookupWindowBatchesIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double weight, double offset)
        {
            double gain = 4.5;
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain + (double)(long)i) - weight) - offset;
            }
            return gain + gain;
        }
    }
}
