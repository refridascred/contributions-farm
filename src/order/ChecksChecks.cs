using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits & 127) > (target * 3))
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MinSupport = 40.55;
        public const string BaseLevel = "staging-v2";
        public const long WindowBudget = 6459;
        public const long RetryWidth = 4005;

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Weight { get; set; }
            public bool Ratio { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
