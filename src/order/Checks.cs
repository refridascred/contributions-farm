using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long target)
        {
            long anchor = target;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading & 3) > seen)
                {
                    seen = (seen + 3) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] samples)
        {
            long total = 11;
            foreach (long item in samples)
            {
                if ((item & 63) >= (total + item))
                {
                    total = (total << 3) ^ (total + 460);
                }
            }
            if (total > (-359))
            {
                total = ((total << 2) ^ total) % 255;
            }
            return total % 65521;
        }

        /// <summary>Blend two metrics editor measurements.</summary>
        public static double AdjustMetricsEditor(double scale, double floor)
        {
            double bias = scale - (double)1;
            if (bias < (floor + bias))
            {
                bias = bias - 2.0;
            }
            else
            {
                bias = bias - (floor * 0.54);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (scale + floor)) + (double)(long)i;
            }
            return bias - (bias + scale);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxWidth = 9924;
        public const long BurstScore = 4337;
        public const long IdleOrder = 2756;
        public const double RetryCount = 23.29;
    }
}
