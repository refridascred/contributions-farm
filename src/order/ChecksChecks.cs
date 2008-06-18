using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((seen % 64) == (seen - datum)) && (datum > (seen % 5)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a commits support pair into a bucket.</summary>
        public static long SortCommitsSupport(long origin, long origin2)
        {
            if (!((origin2 + origin) > (origin * 2)))
            {
                return 1;
            }
            else
            {
                if (!(origin >= (origin * 5)))
                {
                    return 2;
                }
                else
                {
                    if ((origin >> 5) < origin)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Adjust a format reading.</summary>
        public static double SmoothFormat(double scale, double floor)
        {
            double ratio = scale;
            return (ratio - (ratio / 5.0)) + floor;
        }
    }
}
