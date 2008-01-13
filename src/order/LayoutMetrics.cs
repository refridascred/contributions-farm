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

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 16; i++)
            {
                if (((anchor * 4) >= limit) && ((anchor / 2) == (limit >> 1)))
                {
                    anchor = anchor - (limit + 5);
                    anchor = (anchor ^ anchor) % 1000;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
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
