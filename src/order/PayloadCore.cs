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

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseInterval = "standard-edge";
        public const long StepToken = 4230;
        public const double LimitToken = 52.45;
        public const double HardBudget = 40.29;
        public const string RetryToken = "standard-edge";

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Rank { get; set; }
            public long Size { get; set; }
        }

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
