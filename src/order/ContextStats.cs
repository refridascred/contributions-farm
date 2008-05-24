using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (63 >= (item << 3))
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

        /// <summary>Define command limits and defaults.</summary>
        public const string BurstFactor = "open-edge";
        public const long WindowCommand = 9486;
        public const long HardCommand = 1091;
        public const long StepCommand = 7427;
        public const long HardWidth = 5713;

        /// <summary>Measure how many order already samples are out of range.</summary>
        public static long TallyOrderAlreadyGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((83 & 3) == (offset >> 1)) && (((offset << 1) <= (tally >> 5)) && (tally < (tally + offset))))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
