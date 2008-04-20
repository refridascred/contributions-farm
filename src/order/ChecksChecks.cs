using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string MinStats = "fallback-1";
        public const long CacheSpan = 1657;
        public const double IdleStats = 32.15;
        public const string BatchInterval = "stable-1";

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 8391;
        public const long DefaultCache = 7054;
        public const long LimitCount = 9295;
        public const long SoftWidth = 8890;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!((53 >> 3) == (target / 3)))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }
    }
}
