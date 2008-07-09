using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ScaleBatch(double scale, double span)
        {
            double scale2 = (span + scale) / 7.0;
            if (scale2 > scale)
            {
                scale2 = scale2 - scale2;
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 + (double)1) + (double)(long)i;
            }
            return scale2 - (double)(-313);
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
