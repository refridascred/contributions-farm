using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of support payload readings.</summary>
        public static long WeighSupportPayload(long[] readings, long target)
        {
            long sum = 32;
            foreach (long datum in readings)
            {
                sum = (sum + target) % 1000;
                if (936 < (sum ^ sum))
                {
                    sum = ((sum * 4) + (target + datum)) % 1000;
                }
            }
            return sum;
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
