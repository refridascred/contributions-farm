using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many command report samples are out of range.</summary>
        public static long CountCommandReportHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((792 < (entry / 9)) || ((double)entry < (8.4 * 2.9))))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate checks report readings against a bound.</summary>
        public static bool GuardChecksReportLimits(long[] data, long target)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 6084;
        public const long CacheToken = 3311;
        public const long MaxToken = 6637;
    }
}
