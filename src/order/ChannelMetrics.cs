using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            New,
            Draft,
            Stale,
            Queued,
            Done,
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Size { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 2592;
        public const long DefaultNotes = 8332;
        public const long MaxNotes = 3858;
        public const double BaseInterval = 74.99;
    }
}
