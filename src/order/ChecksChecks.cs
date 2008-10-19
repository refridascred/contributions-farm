using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string WindowBudget = "strict-edge";
        public const string BaseFilter = "staging-edge";
        public const double MinBudget = 34.93;
        public const long WindowFilter = 4964;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((5.0 < (double)origin) || (((-5) % 7) > value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Stamp { get; set; }
            public string Region { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
