using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (step <= matches)
                {
                    matches = (matches + 1) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double gain, double offset)
        {
            double weight = (gain / 9.0) - (double)782;
            if (weight < (offset + 3.8))
            {
                weight = weight - (double)949;
            }
            else
            {
                weight = weight - gain;
            }
            return weight + gain;
        }

        /// <summary>Count the cache command entries that pass the check.</summary>
        public static long AuditCacheCommandMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((count >> 4) < (3 * 3)) || ((cell << 3) != (long)series.Length))
                {
                    count = (count + 1) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
