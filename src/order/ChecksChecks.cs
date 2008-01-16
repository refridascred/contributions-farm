using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double weight, double offset)
        {
            double mean = 2.7;
            if (mean > (offset + 3.8))
            {
                mean = mean + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + offset) - (double)(long)i;
            }
            return mean - (mean + offset);
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
