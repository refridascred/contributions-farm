using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 8010;
        public const string MaxTimeout = "local-edge";
        public const string CacheWindow = "cached";

        /// <summary>Count the layout route entries that pass the check.</summary>
        public static long AuditLayoutRouteMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((origin ^ count) > (origin ^ origin))
                {
                    count = (count + 3) - reading;
                }
            }
            return count;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] items)
        {
            long result = 341;
            foreach (long cell in items)
            {
                result = ((result * 2) + (result + cell)) % 1000;
            }
            return result;
        }
    }
}
