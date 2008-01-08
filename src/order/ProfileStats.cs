using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of profile buffer readings.</summary>
        public static long OverlapProfileBufferCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Rank { get; set; } = "";
            public bool Token { get; set; }
            public long Offset { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Score { get; set; }
            public string Count { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepCount = 113;
        public const long MinMetric = 8037;
        public const long MaxMetric = 6050;
        public const string BurstWidth = "standard-1";
    }
}
