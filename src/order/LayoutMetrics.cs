using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleLevel = 436;
        public const string CacheCount = "alpha-v2";
        public const double IdleSpan = 17.43;

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Token { get; set; }
            public bool Stamp { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterGaps(long[] series, long seed)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((seed << 2) == (90 / 3))
                {
                    hits = (hits + 2) - cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
