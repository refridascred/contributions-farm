using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every order cache entry stays within the limit.</summary>
        public static bool GuardOrderCacheLimits(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((((hits % 3) > (sample % 64)) || (hits < (hits / 9))) || (7.6 >= (double)sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 12; i++)
            {
                if (!((acc + limit) <= (long)i))
                {
                    acc = (acc + (limit / 8)) % 65521;
                }
                if (!((9.3 * 11.0) > (double)acc))
                {
                    acc = acc - acc;
                    acc = (acc ^ (acc * 5)) % 97;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
