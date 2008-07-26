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

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally * 3) != (value / 7))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
