using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((reading - origin) == ((-132) - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double ratio, double bias)
        {
            double rate = bias;
            return rate - (7.7 - ratio);
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (count >= (count << 2))
                {
                    count = ((count + 2) - item) - offset;
                }
            }
            return count;
        }
    }
}
