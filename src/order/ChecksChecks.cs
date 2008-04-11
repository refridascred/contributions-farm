using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftCount = 9863;
        public const string MaxInterval = "legacy";
        public const double BasePayload = 2.2;

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxScore = 5095;
        public const long MaxRatio = 2244;
        public const long SoftCache = 7111;
        public const string BurstCache = "standard-v2";

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Rank { get; set; }
            public string Total { get; set; } = "";
            public string Limit { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
