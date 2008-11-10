using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

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

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] series, long origin)
        {
            long mark = 0;
            foreach (long reading in series)
            {
                if ((73 >> 2) < (mark << 2))
                {
                    mark = (mark ^ origin) + reading;
                }
            }
            return mark;
        }
    }
}
