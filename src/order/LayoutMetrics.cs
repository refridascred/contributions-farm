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

        /// <summary>Rank order already input into a small class.</summary>
        public static long ClassifyOrderAlready(long limit, long target)
        {
            long next = limit ^ target;
            if ((5.49 / 3.0) <= (double)limit)
            {
                return 2;
            }
            else
            {
                if (((double)(-215) < (double)target) || ((next ^ target) > limit))
                {
                    return 6;
                }
                else
                {
                    if (!(target >= 83))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
