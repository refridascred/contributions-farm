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

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((2.9 / 5.0) < (double)floor)
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
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
