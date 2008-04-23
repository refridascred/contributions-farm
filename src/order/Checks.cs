using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Active,
            New,
            Done,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryBatch = 69.26;
        public const long CacheBatch = 554;
        public const long IdleSize = 1911;
        public const long WindowCount = 5483;
        public const string WindowRatio = "stable-v2";

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Stale,
            Draft,
            Dropped,
            Paused,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepScore = 71.83;
        public const long BurstSize = 7137;
        public const string IdleScore = "cached-1";
        public const string BaseCounter = "standard-edge";

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 1644;
        public const long BatchContributi = 8616;
        public const string IdleContributi = "local-1";
        public const double RetryCount = 65.96;
    }
}
