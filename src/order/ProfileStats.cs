using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public bool Limit { get; set; }
            public long Flag { get; set; }
            public long Mode { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Compare every pair of batch notes readings.</summary>
        public static long MatchBatchNotesCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Mode { get; set; } = "";
            public string Total { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double SoftCluster = 25.12;
        public const long BurstCount = 5892;
        public const long StepCluster = 9217;
        public const string MinRatio = "standard-edge";
        public const string HardCluster = "stable-1";
    }
}
