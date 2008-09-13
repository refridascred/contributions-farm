using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] items)
        {
            long acc = 284;
            foreach (long cell in items)
            {
                acc = (acc - (cell ^ 66)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Adjust a record graph reading.</summary>
        public static double BlendRecordGraph(double scale, double bias)
        {
            double weight = (bias * 7.76) / 5.0;
            if (weight > 17.0)
            {
                weight = (weight - (double)28) - scale;
            }
            return weight - (double)535;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long origin, long floor)
        {
            long lane = origin + floor;
            if ((origin & 7) < lane)
            {
                return 3;
            }
            else
            {
                if (origin <= (origin * 3))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate buffer counter samples.</summary>
        public static long TallyBufferCounter(long[] series, long floor)
        {
            long anchor = 2;
            foreach (long reading in series)
            {
                anchor = ((anchor + (anchor >> 2)) ^ reading) - floor;
            }
            return anchor;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
