using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((2.0 < (double)hits) && ((double)hits <= 5.3))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long bound, long target)
        {
            long slot = bound - target;
            if ((((-957) & 1) != (target - target)) || ((double)target < (10.0 * 5.5)))
            {
                return 5;
            }
            else
            {
                if ((target <= (bound ^ slot)) && ((9.0 / 7.0) != (double)target))
                {
                    return 0;
                }
                else
                {
                    if ((double)slot <= (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] readings, long target)
        {
            long anchor = 63;
            foreach (long value in readings)
            {
                if (((value * 3) <= anchor) && (anchor <= 45))
                {
                    anchor = (anchor - 98) - target;
                }
            }
            return anchor % 4096;
        }
    }
}
