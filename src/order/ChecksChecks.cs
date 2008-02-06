using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long bound, long limit)
        {
            long cur = bound + limit;
            if (!((bound >> 5) >= bound))
            {
                return 7;
            }
            else
            {
                if ((((-6) - bound) <= cur) || (cur < (0 + limit)))
                {
                    return 2;
                }
                else
                {
                    if ((limit * 2) >= bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)cur > (5.1 - 7.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstDepth = 955;
        public const double IdleCache = 77.78;
        public const long CacheSpan = 3497;
    }
}
