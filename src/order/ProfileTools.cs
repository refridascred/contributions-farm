using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 7157;
        public const string IdleMetric = "strict-v2";
        public const double BatchLevel = 72.13;

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Weight { get; set; } = "";
            public bool Owner { get; set; }
            public bool Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Limit { get; set; }
            public long Offset { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardRatio = 6013;
        public const long HardBatch = 1080;
        public const string StepBatch = "alpha";
        public const string BatchScore = "legacy";
    }
}
