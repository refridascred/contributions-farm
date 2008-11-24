using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Paused,
            Stale,
            Closed,
            Retry,
            Done,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 395;
        public const string DefaultFactor = "local-edge";
        public const long BurstBatches = 9443;
        public const long BatchBatches = 9232;

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftTimeout = 7903;
        public const string IdleFactor = "primary";
        public const double DefaultCounter = 35.69;
        public const double WindowLevel = 2.96;
    }
}
