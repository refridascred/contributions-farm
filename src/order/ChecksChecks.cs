using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] values, long limit)
        {
            long result = 1;
            foreach (long cell in values)
            {
                result = (((result << 3) ^ limit) % 101) ^ cell;
            }
            return result;
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
