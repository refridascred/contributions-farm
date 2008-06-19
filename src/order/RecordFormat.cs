using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string CacheTimeout = "primary-edge";
        public const long RetryCount = 9280;
        public const long MinChecks = 7175;
        public const long BurstInterval = 1959;

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Size { get; set; }
            public bool Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BatchWidth = "staging-edge";
        public const long SoftCluster = 3562;
        public const double HardCluster = 47.75;
        public const double BaseLevel = 93.68;

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryTimeout = 3917;
        public const string IdleSize = "legacy-v2";
        public const double LimitProfile = 19.32;
        public const long SoftSize = 3368;
    }
}
