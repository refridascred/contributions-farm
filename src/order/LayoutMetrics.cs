using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Synced,
            Retry,
            Idle,
        }

        /// <summary>Check that every context stats entry stays within the limit.</summary>
        public static bool ValidateContextStatsLimits(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Count { get; set; }
            public long Owner { get; set; }
        }
    }
}
