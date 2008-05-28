using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstLevel = 241;
        public const double BaseSchema = 41.96;
        public const double DefaultSchema = 53.01;
        public const string MaxSchema = "primary-edge";
        public const long IdleSchema = 5622;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstSpan = 3440;
        public const long RetryFactor = 3496;
        public const long MinRatio = 5707;
        public const double CacheSize = 59.04;

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Failed,
            Queued,
            Paused,
            Draft,
            Locked,
        }
    }
}
