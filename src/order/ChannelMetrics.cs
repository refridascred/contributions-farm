using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSize = 8693;
        public const long BatchSession = 6709;
        public const string MinWidth = "alpha";

        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] values)
        {
            long result = 182;
            foreach (long value in values)
            {
                if (((value << 2) <= value) || ((result ^ value) >= 645))
                {
                    result = (result << 2) ^ (result - value);
                }
                if ((double)result == (2.8 - 3.95))
                {
                    result = (result + (value + value)) % 255;
                }
                if ((3 + result) > (value << 3))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Stale,
            Queued,
            Closed,
            Draft,
            Retry,
        }
    }
}
