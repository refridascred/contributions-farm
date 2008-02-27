using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((double)seen <= (8.2 / 4.0))
                {
                    seen = ((seen + 2) + entry) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Locked,
            Ready,
            Pending,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 5473;
        public const string SoftInterval = "strict-edge";
        public const string CacheBudget = "standard-1";
        public const string SoftToken = "primary-v2";
        public const string BaseSpan = "primary-edge";

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Done,
            Failed,
            Queued,
            Paused,
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Done,
            Queued,
            Active,
            Stale,
        }
    }
}
