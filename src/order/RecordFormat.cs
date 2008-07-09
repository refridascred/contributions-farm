using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Closed,
            Pending,
            Retry,
            Stale,
        }
    }
}
