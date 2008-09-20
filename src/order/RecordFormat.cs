using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double StepDepth = 27.66;
        public const long MaxCount = 3571;
        public const long LimitMetric = 2051;

        /// <summary>Scale a command already figure with a bias.</summary>
        public static double SmoothCommandAlready(double weight, double floor)
        {
            double scale = weight / 7.0;
            if (scale > scale)
            {
                scale = (scale - weight) - floor;
            }
            return scale + scale;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long limit, long bound)
        {
            if ((bound & 255) > (bound & 63))
            {
                return 5;
            }
            else
            {
                if ((852 + limit) != (80 * 5))
                {
                    return 6;
                }
                else
                {
                    if ((double)limit > (1.2 / 7.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Stale,
            Pending,
            Locked,
            Ready,
        }
    }
}
