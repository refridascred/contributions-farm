using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value / 2) == (value & 7))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits / 2) <= (hits ^ bound))
                {
                    hits = (hits + 2) ^ datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long seed, long limit)
        {
            long prev = seed - limit;
            if (!(13.0 > (double)prev))
            {
                return 5;
            }
            else
            {
                if ((double)limit < (double)(-46))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double rate, double bias)
        {
            double scale = bias / 7.0;
            if (scale >= 0.4)
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (scale - scale)) + (double)(long)i;
            }
            return scale + (rate + rate);
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] values, long floor)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((((hits % 60) == (floor + hits)) && ((double)floor <= 11.0)) && ((reading - hits) <= hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
