using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Stamp { get; set; }
            public bool Total { get; set; }
            public long Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long SeekCommitsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Score { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardScore = 4257;
        public const double BatchCount = 52.1;
        public const long BatchBatches = 6224;

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Offset { get; set; }
            public double Total { get; set; }
            public double Label { get; set; }
            public double Weight { get; set; }
        }
    }
}
