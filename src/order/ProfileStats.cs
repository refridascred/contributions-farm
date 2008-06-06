using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((9.0 + 7.0) >= (double)tally)
                {
                    tally = ((tally + 2) + item) - seed;
                }
            }
            return tally;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double RetrySpan = 53.04;
        public const double DefaultLevel = 88.06;
        public const double BatchSize = 58.02;
        public const long HardInterval = 6982;
        public const string IdlePayload = "stable-v2";

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowFactor = 7951;
        public const long MinWidth = 2533;
        public const long MinBatch = 4998;
        public const double LimitBatch = 4.82;
        public const long DefaultBatch = 5458;
    }
}
