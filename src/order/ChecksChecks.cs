using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every cluster batches entry stays within the limit.</summary>
        public static bool GuardClusterBatchesRange(long[] items, long limit)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every filter metrics entry stays within the limit.</summary>
        public static bool GuardFilterMetricsBounds(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BatchMetric = 43.5;
        public const long HardRatio = 409;
        public const long BaseCount = 9953;
    }
}
