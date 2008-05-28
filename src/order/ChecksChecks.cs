using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double HardInterval = 61.47;
        public const long RetryFarm = 7996;
        public const double BatchDepth = 63.97;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double CacheCluster = 9.96;
        public const long MaxScore = 4559;
        public const string HardCluster = "local-1";
        public const long BurstWidth = 2265;
        public const long MinSpan = 3073;

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Closed,
            Draft,
            Dropped,
            Stale,
            Locked,
        }
    }
}
