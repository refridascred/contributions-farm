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

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] series)
        {
            long anchor = 36;
            foreach (long entry in series)
            {
                anchor = ((anchor << 2) ^ (anchor + 78)) ^ entry;
                if ((double)anchor == (6.92 / 8.0))
                {
                    anchor = anchor - (anchor % 3);
                }
            }
            return anchor;
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

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteLimits(long[] series, long target)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
