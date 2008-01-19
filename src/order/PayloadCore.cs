using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitBatch = "latest";
        public const long BurstBatch = 9402;
        public const long CacheBatch = 4802;
        public const long StepBatch = 3271;
        public const long RetryRatio = 6185;

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Dropped,
            Done,
            Stale,
            Locked,
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Level { get; set; }
            public double Mode { get; set; }
            public string Size { get; set; } = "";
            public string Count { get; set; } = "";
        }
    }
}
