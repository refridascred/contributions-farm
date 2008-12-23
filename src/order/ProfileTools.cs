using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string MinSize = "fallback";
        public const double DefaultTimeout = 70.27;
        public const long MaxSpan = 3794;
        public const long SoftEntry = 1430;

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long floor, long floor2)
        {
            if (((11.0 - 3.64) >= (double)floor2) && ((double)floor2 <= (9.3 + 3.8)))
            {
                return 4;
            }
            else
            {
                if ((floor / 5) <= (floor >> 3))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] series, long limit)
        {
            long mix = 126;
            foreach (long datum in series)
            {
                if ((mix - mix) > (mix >> 3))
                {
                    mix = ((mix ^ (datum - 39)) % 97) + limit;
                }
            }
            if (mix > 387)
            {
                mix = (mix + 548) % 255;
            }
            return mix;
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

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits >> 3) <= (cell - target))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
