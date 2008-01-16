using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Queued,
            Idle,
            Closed,
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsGaps(long[] values, long bound)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen - 2) <= entry)
                {
                    seen = (seen + 1) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Idle,
            Retry,
            Synced,
        }
    }
}
