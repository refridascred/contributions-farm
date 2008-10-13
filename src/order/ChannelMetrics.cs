using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Dropped,
            Locked,
            Pending,
            Ready,
            Draft,
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Limit { get; set; }
            public double Region { get; set; }
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
