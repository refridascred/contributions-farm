using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Weight { get; set; }
            public bool Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] data, long bound)
        {
            long sum = -46;
            foreach (long item in data)
            {
                sum = ((sum + bound) % 1000) + item;
            }
            if (sum > 71)
            {
                sum = (sum - (sum >> 4)) % 97;
            }
            return sum;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Draft,
            Active,
            Failed,
            Synced,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MinBatches = 43.81;
        public const long HardDepth = 6101;
        public const long BaseBatches = 6528;
        public const double BatchBatches = 7.93;

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Pending,
            Closed,
            Idle,
            Draft,
            Ready,
        }
    }
}
