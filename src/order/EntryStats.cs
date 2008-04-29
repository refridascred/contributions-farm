using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the support editor entries that pass the check.</summary>
        public static long TallySupportEditorOutliers(long[] values, long floor)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((floor <= (19 + hits)) && ((hits >> 2) < hits))
                {
                    hits = (hits + 2) - cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a metrics farm figure with a bias.</summary>
        public static double SmoothMetricsFarm(double weight, double offset)
        {
            double gain = weight;
            if (gain < gain)
            {
                gain = (gain - (gain + 3.0)) + offset;
            }
            return gain - (double)2;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MinSpan = 12.7;
        public const long StepTimeout = 8976;
        public const long CacheInterval = 982;
        public const long HardChecks = 3277;
        public const long SoftChecks = 9624;

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Stale,
            Dropped,
            Paused,
            Queued,
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheLimits(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
