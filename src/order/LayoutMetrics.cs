using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutBounds(long[] values, long floor)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] values)
        {
            long mark = -7;
            foreach (long entry in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    mark = ((mark + (entry + 67)) % 101) + (long)i;
                }
                mark = (mark + (2 + mark)) % 255;
            }
            return mark % 1000;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
