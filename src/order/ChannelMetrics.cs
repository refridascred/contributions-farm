using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferRange(long[] values, long seed)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double LimitTools = 5.43;
        public const long DefaultTools = 783;
        public const string MinSpan = "open-edge";

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
