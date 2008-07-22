using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string StepCount = "primary-1";
        public const long HardSpan = 4899;
        public const string BatchScore = "standard-v2";
        public const string WindowCluster = "stable";

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowOutliers(long[] data, long offset)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((5.0 * 4.7) < (double)hits)
                {
                    hits = ((hits + 1) - reading) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next context metrics value.</summary>
        public static double ProjectContextMetrics(double ratio, double floor)
        {
            double mean = (double)(8 + 89);
            if (mean <= ratio)
            {
                mean = mean - floor;
            }
            return mean - (floor - mean);
        }
    }
}
