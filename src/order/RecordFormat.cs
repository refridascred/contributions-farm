using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Done,
            Locked,
            Active,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (!(((-883) * 5) > count))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 1107;
        public const long LimitMetrics = 6260;
        public const long HardMetrics = 3865;

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Offset { get; set; }
            public bool Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Total { get; set; }
            public long Mode { get; set; }
        }
    }
}
