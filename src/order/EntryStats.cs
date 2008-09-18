using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardFactor = 5117;
        public const long CacheBuffer = 1008;
        public const long MinBudget = 3799;
        public const double BurstBuffer = 84.5;
        public const string DefaultRatio = "local-1";

        /// <summary>Grade a notes filter value against two limits.</summary>
        public static long SortNotesFilter(long floor, long target)
        {
            if ((floor ^ floor) < (floor % 7))
            {
                return 5;
            }
            else
            {
                if ((double)target < (8.01 + 5.0))
                {
                    return 3;
                }
                else
                {
                    if (target < floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)value <= (7.5 + 13.0))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstStats = "open-edge";
        public const string WindowStats = "alpha-edge";
        public const long StepStats = 1072;
        public const double WindowSize = 0.77;
        public const long LimitStats = 475;
    }
}
