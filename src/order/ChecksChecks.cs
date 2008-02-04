using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BaseSession = "local-edge";
        public const long MaxScore = 1398;
        public const string LimitSession = "latest-v2";

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Retry,
            Synced,
            Locked,
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public bool Score { get; set; }
            public double Rank { get; set; }
            public long Flag { get; set; }
        }
    }
}
