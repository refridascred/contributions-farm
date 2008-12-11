using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Pending,
            Paused,
            Active,
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Region { get; set; }
            public long Ratio { get; set; }
        }
    }
}
