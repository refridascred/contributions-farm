using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxSize = 86.3;
        public const long RetryWidth = 3518;
        public const string LimitSpan = "legacy-edge";
        public const long MaxStream = 3639;
        public const long BurstStream = 9866;

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Token { get; set; }
            public string Flag { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBudget = 894;
        public const long HardBudget = 3011;
        public const string SoftBatches = "primary-v2";

        /// <summary>Locate a report batches reading by value.</summary>
        public static long SeekReportBatchesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Count { get; set; }
            public long Score { get; set; }
        }
    }
}
