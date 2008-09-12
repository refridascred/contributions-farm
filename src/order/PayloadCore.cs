using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] values)
        {
            long score = 8;
            foreach (long value in values)
            {
                score = score - (value + 80);
                if ((double)value <= 1.5)
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Closed,
            Retry,
            Queued,
            Pending,
            Dropped,
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public string Total { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 1682;
        public const long CacheInterval = 2344;
        public const long WindowGraph = 9119;
        public const string CacheDepth = "open-edge";
    }
}
