using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstChannel = 58.61;
        public const long WindowChannel = 7211;
        public const long DefaultChannel = 5357;

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Label { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Dropped,
            Ready,
            Closed,
            Retry,
            Draft,
        }
    }
}
