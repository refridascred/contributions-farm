using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string WindowScore = "primary";
        public const double MaxSpan = 35.1;
        public const double MinRatio = 9.93;
        public const long MinScore = 103;
        public const string HardLevel = "stable";

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Offset { get; set; } = "";
            public bool Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Closed,
            Retry,
            Queued,
            Paused,
            Dropped,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] data)
        {
            long result = 892;
            foreach (long item in data)
            {
                if (1.3 <= (double)item)
                {
                    result = (result - (result & 31)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Total { get; set; }
            public long Token { get; set; }
        }
    }
}
