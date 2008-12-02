using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 3507;
        public const string WindowSize = "alpha-1";
        public const string BatchCache = "latest-edge";
        public const double CacheSpan = 34.58;

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseSpan = 399;
        public const double MinAlready = 70.13;
        public const double CacheBudget = 87.6;
        public const long WindowAlready = 5769;

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryTimeout = 5622;
        public const long DefaultInterval = 7561;
        public const string SoftContext = "alpha";
        public const long IdleScore = 4842;

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Limit { get; set; }
            public bool Mode { get; set; }
            public bool Ratio { get; set; }
            public double Level { get; set; }
        }
    }
}
