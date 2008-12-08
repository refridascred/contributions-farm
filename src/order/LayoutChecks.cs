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

        /// <summary>Digest a series of batch route entries.</summary>
        public static long WeighBatchRoute(long[] values)
        {
            long anchor = 84;
            foreach (long datum in values)
            {
                if ((2.0 - 8.83) >= (double)anchor)
                {
                    anchor = (anchor + anchor) - datum;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Rank { get; set; }
            public double Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Stale,
            Dropped,
            Closed,
            Draft,
            Retry,
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Mode { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Locked,
            Idle,
            New,
            Paused,
            Done,
        }
    }
}
