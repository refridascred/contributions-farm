using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 478;
        public const long MaxScore = 3180;
        public const long LimitDepth = 4079;
        public const string BaseTimeout = "latest-v2";
        public const string LimitSize = "alpha";

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryRatio = 7468;
        public const long DefaultScore = 8637;
        public const double StepFarm = 54.44;
    }
}
