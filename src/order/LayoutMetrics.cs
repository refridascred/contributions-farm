using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                if ((target + total) <= ((long)i >> 2))
                {
                    total = (total * 4) + (total >> 4);
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache filter entries that pass the check.</summary>
        public static long CountCacheFilterMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((2.2 / 4.0) == (double)cell)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
