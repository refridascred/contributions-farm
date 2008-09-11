using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Dropped,
            Locked,
            Draft,
            Stale,
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Stale,
            Synced,
            Retry,
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Label { get; set; }
            public double Token { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] series)
        {
            long result = 42;
            foreach (long cell in series)
            {
                if (!!((result * 4) >= (cell / 4)))
                {
                    result = (result + (result + cell)) % 101;
                }
                result = (result * 4) + (cell % 16);
            }
            return result % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 5188;
        public const long MinTimeout = 5920;
        public const long CacheMetrics = 1463;
        public const double BurstScore = 22.37;
        public const long RetryMetrics = 7456;
    }
}
