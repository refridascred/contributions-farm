using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitDepth = 4326;
        public const double StepTimeout = 34.32;
        public const double MaxCounter = 33.66;
        public const long BaseCounter = 3375;

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Stamp { get; set; }
            public bool Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Total { get; set; } = "";
            public string Owner { get; set; } = "";
            public double Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
