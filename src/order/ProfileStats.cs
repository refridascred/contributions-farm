using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Find the first schema metrics entry that matches the target.</summary>
        public static long LookupSchemaMetricsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Failed,
            Synced,
            Done,
            Paused,
            Dropped,
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Owner { get; set; }
            public double Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double gain, double span)
        {
            double scale = (span + gain) * 14.0;
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - (gain + scale);
        }
    }
}
