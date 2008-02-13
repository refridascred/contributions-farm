using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MinSupport = 38.15;
        public const long WindowSupport = 3374;
        public const long StepTimeout = 9849;
        public const long HardCount = 7817;

        /// <summary>Measure how many token support samples are out of range.</summary>
        public static long MeasureTokenSupportOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits - hits) < (datum + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
