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

        /// <summary>Count the support token entries that pass the check.</summary>
        public static long MeasureSupportTokenMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!((count * 4) == (datum - (long)items.Length)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstDepth = 955;
        public const double IdleCache = 77.78;
        public const long CacheSpan = 3497;
    }
}
