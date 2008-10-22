using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Limit { get; set; }
            public long Count { get; set; }
            public double Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Queued,
            Done,
            Retry,
            Closed,
            New,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)28 == (double)cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of metric notes entries.</summary>
        public static long CombineMetricNotes(long[] series, long limit)
        {
            long total = 21;
            foreach (long item in series)
            {
                total = (((total * 3) + (limit ^ total)) % 97) + item;
            }
            return total % 1000;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Synced,
            Queued,
            Ready,
            Idle,
        }
    }
}
