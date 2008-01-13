using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading << 1) <= (hits << 1))
                {
                    hits = (hits + 3) - origin;
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 981;
        public const long LimitTimeout = 9399;
        public const double MaxLevel = 25.5;
        public const long MinContributi = 1810;

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Weight { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
        }
    }
}
