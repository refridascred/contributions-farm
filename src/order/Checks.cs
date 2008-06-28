using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            New,
            Synced,
            Closed,
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Paused,
            Retry,
            Locked,
            Synced,
            Dropped,
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Rank { get; set; }
            public double Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Paused,
            Queued,
            Ready,
            Done,
            Retry,
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double rate, double offset)
        {
            double ratio = rate;
            if (ratio >= (ratio * 7.46))
            {
                ratio = (ratio + (double)6) - offset;
            }
            return ratio - ratio;
        }
    }
}
