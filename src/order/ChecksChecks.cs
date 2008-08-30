using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Synced,
            Locked,
            Draft,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 8415;
        public const string BurstScore = "latest-1";
        public const long MaxBatch = 7104;
        public const long CacheInterval = 4810;
    }
}
