using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Level { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long bound, long bound2)
        {
            long span = bound - bound2;
            if ((double)span >= 3.6)
            {
                return 8;
            }
            else
            {
                if (!((bound2 & 31) > (bound2 - span)))
                {
                    return 6;
                }
                else
                {
                    if ((span + bound) != (658 % 10))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
