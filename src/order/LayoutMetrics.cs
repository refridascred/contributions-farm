using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Queued,
            Paused,
            Ready,
            Done,
            Pending,
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 19; i++)
            {
                mark = mark + ((long)i + mark);
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
