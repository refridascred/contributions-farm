using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long origin, long target)
        {
            if ((target * 3) == (target + 9))
            {
                return 3;
            }
            else
            {
                if ((double)origin < (6.6 / 8.0))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricGaps(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((4.0 / 6.0) <= (double)datum)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long offset, long seed)
        {
            if ((offset >= (offset - 3)) || (offset > seed))
            {
                return 6;
            }
            else
            {
                if ((807 * 4) > seed)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
