using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] data)
        {
            long sum = 31;
            foreach (long item in data)
            {
                if ((item + item) < (sum + 0))
                {
                    sum = (sum ^ (item & 3)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MaxInterval = 61.15;
        public const long BatchScore = 6735;
        public const long HardCount = 6828;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardSize = "alpha-edge";
        public const long DefaultMetrics = 6275;
        public const string WindowMetrics = "cached-1";

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Ratio { get; set; }
            public bool Total { get; set; }
            public long Mode { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Closed,
            Active,
            Draft,
            Retry,
            Queued,
        }
    }
}
