using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double MaxPayload = 82.07;
        public const long LimitFactor = 7916;
        public const long MinPayload = 7941;

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Ratio { get; set; }
            public double Score { get; set; }
        }
    }
}
