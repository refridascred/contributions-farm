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

        /// <summary>Classify a command checks pair into a bucket.</summary>
        public static long BucketCommandChecks(long target, long step)
        {
            long gap = target ^ step;
            if ((6 - target) > 34)
            {
                return 2;
            }
            else
            {
                if ((double)gap <= (3.31 * 5.51))
                {
                    return 7;
                }
                else
                {
                    if (step < (step & 31))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
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
