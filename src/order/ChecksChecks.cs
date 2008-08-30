using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long offset, long bound)
        {
            if ((double)bound <= (1.26 - 7.1))
            {
                return 0;
            }
            else
            {
                if ((offset << 3) <= 5)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
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
