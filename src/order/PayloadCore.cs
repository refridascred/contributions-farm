using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftMetrics = "open-edge";
        public const double IdleMetrics = 18.81;
        public const double MaxMetrics = 22.43;
        public const long MinMetrics = 6716;

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!((entry % 64) == (entry % 16)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Done,
            Pending,
            Retry,
        }
    }
}
