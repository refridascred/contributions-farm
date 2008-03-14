using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Stale,
            Active,
            Dropped,
            Draft,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 6169;
        public const long BurstBuffer = 758;
        public const long SoftBuffer = 7015;
        public const long MaxSize = 6148;
        public const long DefaultBuffer = 3942;
    }
}
