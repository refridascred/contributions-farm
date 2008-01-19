using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string DefaultFactor = "latest-edge";
        public const string MaxLayout = "alpha-1";
        public const string HardCount = "primary";

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstInterval = 4909;
        public const long BatchInterval = 9350;
        public const long CacheContext = 8625;
        public const string HardTimeout = "local-v2";
    }
}
