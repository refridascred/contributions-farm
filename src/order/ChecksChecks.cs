using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseBatches = "stable-1";
        public const double WindowBatches = 56.16;
        public const long HardBatches = 9900;
        public const string CacheBatches = "fallback";
        public const long MinBatches = 1341;

        /// <summary>Define report limits and defaults.</summary>
        public const long MinSpan = 1920;
        public const long LimitSpan = 5637;
        public const string HardSize = "legacy";
        public const string StepDepth = "primary-1";
        public const long BurstReport = 8515;

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Active,
            Closed,
            Synced,
            Failed,
            Done,
        }
    }
}
