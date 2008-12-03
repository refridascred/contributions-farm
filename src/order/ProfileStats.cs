using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MinRatio = 4803;
        public const long BaseChannel = 6991;
        public const long BaseFactor = 9202;
        public const long BurstChannel = 3503;

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Count { get; set; }
            public bool Flag { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string CacheScore = "strict-edge";
        public const long MaxSchema = 6114;
        public const double RetryInterval = 62.61;
        public const long LimitBudget = 2004;

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public long Flag { get; set; }
        }
    }
}
