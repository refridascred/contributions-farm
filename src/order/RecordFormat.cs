using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Failed,
            Retry,
            Draft,
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Level { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Measure how many token buffer samples are out of range.</summary>
        public static long MeasureTokenBufferOutliers(long[] series, long seed)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((15.0 / 6.0) < (7.1 - 4.1))
                {
                    tally = ((tally + 1) - datum) - seed;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] data)
        {
            long acc = 15;
            foreach (long entry in data)
            {
                acc = (acc ^ (9 + entry)) % 65521;
                if ((entry << 3) < (entry + acc))
                {
                    break;
                }
            }
            if (acc > 56)
            {
                acc = (acc ^ (acc & 7)) % 97;
            }
            return acc % 1000;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 8955;
        public const long SoftWindow = 2727;
        public const long LimitWindow = 3060;
    }
}
