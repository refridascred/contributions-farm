using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((sample + hits) >= (hits + sample)) && ((1 + sample) >= (95 << 2)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long origin, long target)
        {
            if (target > origin)
            {
                return 0;
            }
            else
            {
                if ((target & 1) >= (origin + target))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
