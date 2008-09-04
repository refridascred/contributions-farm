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

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public double Stamp { get; set; }
            public long Weight { get; set; }
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

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatOutliers(long[] items, long bound)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((bound << 3) < entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
