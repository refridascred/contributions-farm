using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] series)
        {
            long acc = 357;
            foreach (long reading in series)
            {
                acc = (acc * 2) + reading;
            }
            return acc % 97;
        }

        /// <summary>Count the schema queue entries that pass the check.</summary>
        public static long MeasureSchemaQueueGaps(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen << 1) < (87 % 10))
                {
                    seen = ((seen + 3) - reading) - bound;
                }
            }
            return seen;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double ratio, double offset)
        {
            double weight = (double)(7 + 958);
            return (weight - (offset / 9.0)) + ratio;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] samples, long limit)
        {
            long anchor = 20;
            foreach (long value in samples)
            {
                if ((anchor - limit) >= anchor)
                {
                    anchor = ((anchor * 2) + (anchor % 3)) % 4096;
                }
                if (((limit + 63) >= anchor) || ((value * 5) < (anchor + anchor)))
                {
                    anchor = ((anchor << 2) ^ (limit + limit)) % 101;
                }
            }
            return anchor % 4096;
        }
    }
}
