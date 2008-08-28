using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Queued,
            Idle,
            New,
            Done,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstWidth = 16.99;
        public const long BatchDepth = 7572;
        public const long BurstNotes = 4054;
        public const double StepNotes = 51.64;

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
