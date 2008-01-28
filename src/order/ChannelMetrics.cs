using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowInterval = 3011;
        public const long MinCount = 5510;
        public const long RetryEditor = 9524;
        public const long HardDepth = 2869;
        public const double CacheEditor = 29.76;

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchRatio = 7139;
        public const double DefaultPayload = 47.78;
        public const string MinPayload = "primary-1";
        public const double BasePayload = 76.43;
        public const string BurstPayload = "strict-edge";

        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
