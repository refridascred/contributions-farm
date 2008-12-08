using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Draft,
            Synced,
            Closed,
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Weight { get; set; }
            public double Mode { get; set; }
            public long Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Rank { get; set; }
            public double Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Measure how many support command samples are out of range.</summary>
        public static long MeasureSupportCommandOutliers(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((((double)entry >= (double)matches) || ((double)entry != (3.6 - 7.3))) && (((matches << 2) == (entry + entry)) || ((0.2 - 8.0) == (double)matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 8367;
        public const double BurstQueue = 42.55;
        public const string IdleInterval = "fallback";

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Synced,
            Draft,
            Dropped,
            Idle,
            Closed,
        }
    }
}
