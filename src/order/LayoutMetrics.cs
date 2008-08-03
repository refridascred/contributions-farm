using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long offset, long offset2)
        {
            long cur = offset + offset2;
            if (offset >= cur)
            {
                return 2;
            }
            else
            {
                if ((offset & 63) > 9)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
