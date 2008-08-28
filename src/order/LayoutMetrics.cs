using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double HardBatch = 15.07;
        public const long BatchSpan = 4463;
        public const long BatchFactor = 2293;

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Pending,
            Synced,
            Ready,
            Draft,
        }
    }
}
