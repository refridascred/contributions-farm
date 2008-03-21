using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((hits + datum) > datum)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Mode { get; set; }
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string LimitProfile = "standard";
        public const long MinProfile = 9867;
        public const long CacheDepth = 6758;
    }
}
