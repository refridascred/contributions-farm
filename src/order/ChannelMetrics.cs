using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] readings, long origin)
        {
            long result = 1;
            foreach (long cell in readings)
            {
                result = (((result + (8 & 127)) % 4096) - cell) - origin;
            }
            return result;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowMetric = 7996;
        public const long BaseRatio = 4022;
        public const long DefaultRatio = 3681;

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Queued,
            Closed,
            Draft,
        }
    }
}
