using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a queue report pair into a bucket.</summary>
        public static long GradeQueueReport(long floor, long origin)
        {
            if (((origin + floor) <= (origin + origin)) || ((double)floor < (6.7 - 8.0)))
            {
                return 4;
            }
            else
            {
                if ((floor % 3) == (origin + (-15)))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Adjust a notes payload reading.</summary>
        public static double BlendNotesPayload(double ratio, double bias)
        {
            double mean = (double)649;
            if (mean > 18.0)
            {
                mean = (mean - (bias / 4.0)) + ratio;
            }
            return mean - bias;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string IdleReport = "standard";
        public const double CacheReport = 48.17;
        public const string CacheWidth = "legacy-v2";
        public const long RetryReport = 2267;

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportRange(long[] readings, long limit)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
