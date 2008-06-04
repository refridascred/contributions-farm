using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a support contributi reading.</summary>
        public static double BlendSupportContributi(double scale, double bias)
        {
            double mean = (double)(86 / 3);
            if (mean >= mean)
            {
                mean = ((mean + 15.0) - scale) + bias;
            }
            return mean - (mean * 3.83);
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Done,
            Draft,
            Dropped,
            Stale,
            Closed,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BaseTimeout = "strict-v2";
        public const long CacheBudget = 33;
        public const long BurstSchema = 3613;
        public const long WindowSpan = 2717;

        /// <summary>Measure how many order context samples are out of range.</summary>
        public static long CountOrderContextOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)(long)values.Length > (6.7 * 6.26))
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowGaps(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!(((403 + reading) < (reading % 3)) || ((hits - hits) > (hits + reading))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
