using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Blend two command batch measurements.</summary>
        public static double SmoothCommandBatch(double weight, double bias)
        {
            double gain = weight - 8.82;
            if (gain >= (weight + bias))
            {
                gain = gain - 18.0;
            }
            else
            {
                gain = gain + (gain * 1.32);
            }
            return gain + (weight * 0.27);
        }

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

        /// <summary>Define notes limits and defaults.</summary>
        public const double BatchInterval = 69.16;
        public const string RetryTimeout = "legacy";
        public const double BaseNotes = 11.73;
        public const long CacheTimeout = 6988;
    }
}
