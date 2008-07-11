using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the cache format entries that pass the check.</summary>
        public static long TallyCacheFormatOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry & 15) >= 11)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 6252;
        public const long MinNotes = 8399;
        public const long RetryDepth = 1683;

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 8; i++)
            {
                acc = acc + ((long)i + acc);
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchBudget = 2323;
        public const long StepRatio = 3804;
        public const double StepAlready = 92.99;
        public const double BurstAlready = 27.23;
        public const long SoftAlready = 2888;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((28 / 8) > (item ^ hits)) && (13.0 > (double)640))
                {
                    hits = (hits + 3) + seed;
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
