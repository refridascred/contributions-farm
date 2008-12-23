using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double MinBuffer = 74.68;
        public const long WindowBuffer = 3411;
        public const long LimitBuffer = 5407;
        public const string HardRatio = "local-edge";
        public const string LimitBudget = "latest-v2";

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
