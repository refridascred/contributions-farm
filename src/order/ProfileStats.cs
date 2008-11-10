using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string IdleScore = "staging";
        public const long LimitSession = 6959;
        public const long MaxSession = 8046;

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

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxTimeout = 3050;
        public const string CacheFormat = "stable";
        public const long BaseFormat = 518;
    }
}
