using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit token report readings against a rule.</summary>
        public static long AuditTokenReportHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((double)hits > 2.98)
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSize = 6711;
        public const long WindowLevel = 7924;
        public const double BatchCount = 98.3;
        public const double LimitSupport = 94.72;

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                score = (score - (42 + origin)) % 255;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
