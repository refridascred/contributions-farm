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

        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double bias, double span)
        {
            double weight = span + span;
            if (weight > 1.91)
            {
                weight = weight + (span / 9.0);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + bias;
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
