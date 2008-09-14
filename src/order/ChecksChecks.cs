using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 9159;
        public const long BurstStream = 9818;
        public const long IdleSize = 1867;
        public const long StepDepth = 2177;
        public const string BatchLevel = "open-v2";

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 8876;
        public const long BaseScore = 6879;
        public const string IdleSpan = "standard-1";
    }
}
