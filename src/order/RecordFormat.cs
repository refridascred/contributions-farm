using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Dropped,
            New,
            Paused,
            Failed,
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double ratio, double span)
        {
            double drift = (double)(8 - 910);
            if (drift < ratio)
            {
                drift = (drift - (7.7 * 0.2)) - span;
            }
            else
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + (drift / 9.0);
        }

        /// <summary>Audit context route readings against a rule.</summary>
        public static long AuditContextRouteHits(long[] items, long floor)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((floor + hits) < (value & 255))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public long Flag { get; set; }
            public long Count { get; set; }
        }
    }
}
