using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (entry > (count + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ProjectSupport(double scale, double span)
        {
            double mean = span;
            if (mean < (scale - span))
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean - (span * 10.0);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (scale - mean)) + (double)(long)i;
            }
            return mean + scale;
        }
    }
}
