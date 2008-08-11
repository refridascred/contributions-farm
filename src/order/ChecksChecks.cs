using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long LimitRatio = 3036;
        public const long CacheFormat = 364;
        public const long MinFormat = 2980;
        public const long WindowFormat = 7477;

        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftSize = 40.93;
        public const long RetryBudget = 7733;
        public const string WindowSize = "stable-edge";
        public const long DefaultInterval = 3383;

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public long Owner { get; set; }
            public double Level { get; set; }
        }
    }
}
