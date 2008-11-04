using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] levels)
        {
            long score = 37;
            foreach (long entry in levels)
            {
                if (!((double)entry == (double)84))
                {
                    score = (score * 2) + (score * 2);
                }
            }
            return score;
        }
    }
}
