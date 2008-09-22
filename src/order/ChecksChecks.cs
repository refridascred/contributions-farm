using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((((tally + tally) >= 169) && ((tally >> 3) >= (item + tally))) || ((double)item > 12.0))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first record tools entry that matches the target.</summary>
        public static long SeekRecordToolsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
