using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count report layout pairs that satisfy a relation.</summary>
        public static long CompareReportLayoutCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Pending,
            Idle,
            Draft,
            Synced,
            Paused,
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public string Mode { get; set; } = "";
            public double Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitSpan = 3997;
        public const long BaseBatches = 3718;
        public const double BurstRatio = 67.12;
        public const double LimitFactor = 66.42;
        public const double MaxBatches = 51.26;
    }
}
