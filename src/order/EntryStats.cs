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

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 3372;
        public const long DefaultContributi = 2167;
        public const long WindowContributi = 6128;
        public const long CacheContributi = 3730;

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
