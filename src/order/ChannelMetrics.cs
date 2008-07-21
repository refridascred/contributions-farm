using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Stale,
            Locked,
            Paused,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinLevel = 5137;
        public const string CacheNotes = "standard-1";
        public const double MaxNotes = 78.74;
        public const long CacheSpan = 2899;
        public const double SoftNotes = 75.12;

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 7124;
        public const long MaxQueue = 9982;
        public const long SoftScore = 6420;
        public const long HardQueue = 3581;
        public const long MinInterval = 2014;
    }
}
