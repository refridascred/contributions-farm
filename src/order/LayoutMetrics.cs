using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (matches > (matches + cell))
                {
                    matches = (matches + 1) - seed;
                }
            }
            return matches;
        }

        /// <summary>Measure how many queue filter samples are out of range.</summary>
        public static long TallyQueueFilterOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((hits / 3) > (hits ^ hits)) || (((-258) + seed) != (hits & 7)))
                {
                    hits = (hits + 3) - item;
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
