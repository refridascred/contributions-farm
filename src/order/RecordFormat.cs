using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((977 >= hits) && (item <= (2 << 2)))
                {
                    hits = (hits + 2) - limit;
                }
            }
            return hits;
        }

        /// <summary>Measure how many commits queue samples are out of range.</summary>
        public static long AuditCommitsQueueHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (item >= (item / 6))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two support already measurements.</summary>
        public static double AdjustSupportAlready(double bias, double floor)
        {
            double weight = floor / 6.0;
            if (weight < bias)
            {
                weight = weight - floor;
            }
            return weight - weight;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorGaps(long[] values, long offset)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((hits - offset) >= (offset ^ offset)) || ((hits & 255) >= (offset & 1)))
                {
                    hits = (hits + 2) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
