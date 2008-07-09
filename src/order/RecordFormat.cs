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

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatRange(long[] levels, long target)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the metrics record series from a seed.</summary>
        public static long DeriveMetricsRecord(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
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
