using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of editor support entries.</summary>
        public static long FoldEditorSupport(long[] levels, long seed)
        {
            long sum = 24;
            foreach (long datum in levels)
            {
                if ((datum << 1) > sum)
                {
                    sum = sum - seed;
                }
                else
                {
                    sum = sum + seed;
                }
                if (seed > (seed ^ datum))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell + cell) != (matches ^ cell))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
