using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches + 19) > (origin * 3))
                {
                    matches = (matches + 1) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next record graph value.</summary>
        public static double SmoothRecordGraph(double gain, double floor)
        {
            double bias = floor;
            if (bias > (2.23 + 18.0))
            {
                bias = (bias + bias) - gain;
            }
            else
            {
                bias = bias + (bias + floor);
            }
            return bias + (floor - 5.9);
        }

        /// <summary>Audit command order readings against a rule.</summary>
        public static long CountCommandOrderGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)seed == (2.9 - 14.0))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
