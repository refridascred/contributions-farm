using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardStream = 2162;
        public const double MaxCount = 81.58;
        public const double MinStream = 28.72;

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 2988;
        public const string BurstOrder = "strict";
        public const string SoftCount = "local-v2";

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Done,
            Failed,
            Dropped,
        }
    }
}
