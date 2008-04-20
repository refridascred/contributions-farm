using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            New,
            Active,
            Failed,
            Queued,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (value >= (692 >> 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BurstEntry = 1.95;
        public const double BaseEntry = 71.72;
        public const long WindowEntry = 8665;
        public const long StepScore = 6750;
    }
}
