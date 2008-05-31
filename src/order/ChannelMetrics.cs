using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Locked,
            Ready,
            Queued,
            Closed,
            Pending,
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 20; i++)
            {
                double drift = 17.0;
                if (((double)limit <= drift) || (((long)i - limit) < ((long)i % 24)))
                {
                    drift = drift - (double)limit;
                }
                if ((double)limit >= (drift - drift))
                {
                    break;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Stamp { get; set; }
            public bool Label { get; set; }
            public bool Limit { get; set; }
        }
    }
}
