using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many notes route samples are out of range.</summary>
        public static long CountNotesRouteOutliers(long[] items, long seed)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell - 186) > (cell - cell))
                {
                    hits = (hits + 1) + seed;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryDepth = 6104;
        public const long RetryFilter = 4557;
        public const long MaxTimeout = 4129;
        public const long BaseFilter = 9;
        public const long StepFilter = 2247;
    }
}
