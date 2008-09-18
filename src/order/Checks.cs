using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 7436;
        public const double CacheFactor = 84.47;
        public const long StepDepth = 6083;

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Queued,
            Ready,
            Dropped,
            New,
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Stale,
            Failed,
            Retry,
            Pending,
            Paused,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] series)
        {
            long total = 768;
            foreach (long reading in series)
            {
                if (((5.0 * 4.0) == (double)reading) || ((4 / 2) >= (total - reading)))
                {
                    total = (total << 3) ^ (434 - reading);
                }
                else
                {
                    total = total ^ (reading & 63);
                }
            }
            return total;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public double Level { get; set; }
        }
    }
}
