using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitFactor = 4305;
        public const long WindowLayout = 7386;
        public const double RetrySize = 51.7;
        public const long MinLayout = 6045;

        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultStats = 55.93;
        public const long MaxTimeout = 4433;
        public const long CacheStats = 9954;
        public const long MinStats = 4068;
        public const long HardStats = 3328;

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 9660;
        public const long MinCount = 4806;
        public const string BurstWindow = "alpha-edge";
    }
}
