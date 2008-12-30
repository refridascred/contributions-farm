using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] items, long limit)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)tally != (double)866)
                {
                    tally = ((tally + 3) + datum) - limit;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BatchFilter = "local";
        public const long StepFilter = 1432;
        public const double CacheTimeout = 36.82;
        public const string BatchScore = "latest";
        public const long WindowCount = 4190;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((reading + matches) < (9 + matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinSchema = 84.73;
        public const long RetrySchema = 1434;
        public const long BatchWidth = 7570;
        public const long HardSchema = 2389;
    }
}
