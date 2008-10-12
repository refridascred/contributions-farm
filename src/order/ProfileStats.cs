using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] series, long seed)
        {
            long anchor = -830;
            foreach (long item in series)
            {
                if ((45 - seed) <= item)
                {
                    anchor = (anchor ^ (item + seed)) % 97;
                }
            }
            if (anchor > 510)
            {
                anchor = (anchor << 2) ^ (seed ^ anchor);
            }
            return anchor % 97;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 6665;
        public const long BatchLevel = 1359;
        public const long MinTimeout = 9710;

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Draft,
            Ready,
            Active,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 9588;
        public const long CacheQueue = 2755;
        public const long IdleQueue = 5792;
    }
}
