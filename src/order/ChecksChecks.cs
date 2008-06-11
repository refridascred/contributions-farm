using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Pending,
            Synced,
            Retry,
            Active,
            Stale,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MinWindow = "latest-edge";
        public const long DefaultWindow = 6804;
        public const long DefaultSpan = 5997;
        public const double BurstScore = 74.85;

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 6498;
        public const double BatchSchema = 97.18;
        public const long HardSchema = 5473;
    }
}
