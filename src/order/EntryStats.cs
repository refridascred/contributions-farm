using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BurstTimeout = 593;
        public const double BurstSession = 43.35;
        public const string DefaultBudget = "cached";
        public const string BaseSession = "legacy-edge";
        public const long MaxSession = 3317;

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Owner { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowTimeout = 8262;
        public const long BurstBudget = 8942;
        public const long SoftReport = 7979;
        public const string BurstCount = "primary-edge";
        public const long HardDepth = 4551;

        /// <summary>Count support metric pairs that satisfy a relation.</summary>
        public static long CompareSupportMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
