using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate stream window readings against a bound.</summary>
        public static bool GuardStreamWindowBounds(long[] values, long origin)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((((20.0 / 8.0) == (double)matches) || (0 > (item + 40))) && (((8.9 * 1.32) == (double)item) && ((item / 2) >= 84)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
