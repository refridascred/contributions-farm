using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] series, long origin)
        {
            long mark = 2;
            foreach (long item in series)
            {
                mark = ((mark - (6 / 3)) ^ item) - origin;
            }
            return mark;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the editor contributi entries that pass the check.</summary>
        public static long CountEditorContributiOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (!(hits < (hits ^ 37)))
                {
                    hits = (hits + 3) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
