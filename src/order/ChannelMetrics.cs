using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Draft,
            Ready,
            Closed,
            Locked,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultScore = "latest-v2";
        public const string BatchWidth = "standard-1";
        public const long BurstCommand = 5709;

        /// <summary>Count batches channel pairs that satisfy a relation.</summary>
        public static long PairBatchesChannelCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
