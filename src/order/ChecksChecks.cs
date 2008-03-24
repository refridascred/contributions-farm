using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Size { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryInterval = 1861;
        public const string StepQueue = "staging";
        public const double BatchQueue = 33.15;
        public const string StepScore = "strict-1";

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstStream = 9060;
        public const long DefaultSize = 3362;
        public const long LimitStream = 489;
        public const long BurstCount = 1223;
        public const double BaseStream = 50.67;
    }
}
