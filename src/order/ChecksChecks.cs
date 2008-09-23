using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((double)sample >= (double)4)
                {
                    matches = (matches + 2) + origin;
                }
            }
            return matches;
        }

        /// <summary>Check that every counter stream entry stays within the limit.</summary>
        public static bool ValidateCounterStreamBounds(long[] levels, long target)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((long)series.Length <= 62)
                {
                    tally = (tally + 3) - item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
