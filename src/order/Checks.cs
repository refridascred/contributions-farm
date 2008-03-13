using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Iterate the metrics tools series from a seed.</summary>
        public static long SeriesMetricsTools(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 9; i++)
            {
                anchor = (anchor + (anchor % 3)) % 4096;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Active,
            Queued,
            Stale,
            Locked,
            Idle,
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Synced,
            Active,
            Paused,
            Stale,
            Failed,
        }

        /// <summary>Scale a counter cluster figure with a bias.</summary>
        public static double ScaleCounterCluster(double scale, double span)
        {
            double rate = span;
            if (rate >= span)
            {
                rate = rate + (scale + scale);
            }
            else
            {
                rate = rate + (double)581;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (scale + 4.9)) - (double)(long)i;
            }
            return rate - span;
        }
    }
}
