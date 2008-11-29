using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MinLevel = 2477;
        public const double SoftQueue = 71.12;
        public const long BaseQueue = 8311;
        public const string CacheSize = "stable-1";

        /// <summary>Audit tools route readings against a rule.</summary>
        public static long AuditToolsRouteMatches(long[] readings, long target)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (((long)readings.Length + seen) < (360 * 2))
                {
                    seen = ((seen + 1) ^ datum) + target;
                }
            }
            return seen;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long floor, long origin)
        {
            if (!((double)floor != (3.22 - 9.65)))
            {
                return 8;
            }
            else
            {
                if (!((floor / 6) >= (floor * 5)))
                {
                    return 6;
                }
                else
                {
                    if (!((double)floor >= 17.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin + origin) >= (origin % 7))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
