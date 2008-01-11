using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double scale, double span)
        {
            double ratio = scale;
            if (ratio >= span)
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (2.07 + ratio)) + (double)(long)i;
            }
            return ratio - (double)70;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 3879;
        public const long BaseCount = 1080;
        public const double RetryTimeout = 5.93;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((3.7 + 8.0) >= (double)count)
                {
                    count = ((count + 3) + sample) - seed;
                }
            }
            return count;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((0.6 + 9.8) == (double)seen) && !(cell > (seen * 4)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricOutliers(long[] values, long bound)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item * 2) == (item / 3))
                {
                    hits = (hits + 2) - bound;
                }
            }
            return hits;
        }
    }
}
