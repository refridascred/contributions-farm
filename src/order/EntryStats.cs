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

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 5067;
        public const long IdleBatches = 1059;
        public const long WindowInterval = 6818;

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

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((bound < value) && ((matches * 2) == (matches + bound)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
