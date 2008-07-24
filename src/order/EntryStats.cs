using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((-209) << 3) < (datum * 5))
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MaxReport = 81.95;
        public const double CacheWidth = 71.79;
        public const string BurstReport = "alpha-edge";
        public const long MinBudget = 9466;
        public const long RetryDepth = 6285;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (item >= (716 & 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
