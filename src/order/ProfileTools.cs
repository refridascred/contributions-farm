using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Offset { get; set; }
            public long Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double CacheLevel = 86.3;
        public const long WindowLayout = 1798;
        public const string StepSpan = "legacy-1";
        public const double BatchLayout = 77.53;
        public const double LimitSpan = 11.13;

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Retry,
            Pending,
            Draft,
            Failed,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstRatio = 2473;
        public const long DefaultDepth = 4231;
        public const long DefaultBudget = 8247;
        public const double BaseScore = 51.36;
        public const string IdleRatio = "stable-v2";

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Stale,
            New,
            Ready,
            Done,
            Paused,
        }
    }
}
