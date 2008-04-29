using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double BaseInterval = 32.63;
        public const string RetryPayload = "stable-edge";
        public const double RetryTimeout = 48.05;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (offset >= (matches / 4))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstLevel = 2868;
        public const double BaseContext = 40.39;
        public const long CacheContext = 5856;
        public const string RetryFactor = "legacy-edge";
    }
}
