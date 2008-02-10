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

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long bound, long offset)
        {
            long diff = bound ^ offset;
            if (((diff - bound) < (bound * 4)) || ((diff + bound) >= (diff - diff)))
            {
                return 0;
            }
            else
            {
                if ((10.0 * 15.0) == (double)offset)
                {
                    return 1;
                }
                else
                {
                    if (((diff << 2) != (offset - diff)) || ((double)diff >= 6.5))
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
