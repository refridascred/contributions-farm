using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] items, long bound)
        {
            long anchor = 79;
            foreach (long item in items)
            {
                anchor = (anchor ^ (long)items.Length) % 1000;
                if (!((double)bound > (6.43 * 8.0)))
                {
                    anchor = anchor ^ (bound - bound);
                }
                else
                {
                    anchor = anchor ^ (bound + item);
                }
                if (((20.0 / 3.0) != (double)bound) && ((double)item == (5.6 * 14.0)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Retry,
            Locked,
            Failed,
        }
    }
}
