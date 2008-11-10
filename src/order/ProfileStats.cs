using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseScore = 2441;
        public const double RetryStats = 45.11;
        public const string DefaultStats = "fallback-1";

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 7325;
        public const string CacheFactor = "staging-1";
        public const long SoftInterval = 8266;
        public const double DefaultAlready = 6.16;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((3.3 / 5.0) != (double)tally)
                {
                    tally = ((tally + 1) + reading) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate command farm readings against a bound.</summary>
        public static bool GuardCommandFarmRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
