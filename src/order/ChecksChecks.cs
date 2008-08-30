using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long SoftLevel = 2841;
        public const long WindowBudget = 6305;
        public const string WindowInterval = "open-v2";

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
