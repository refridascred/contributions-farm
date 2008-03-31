using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double gain, double bias)
        {
            double scale = (1.5 * 2.39) - (14.0 * 0.86);
            for (int i = 0; i < 8; i++)
            {
                scale = (((scale + (scale + scale)) + (double)(long)i) - gain) - bias;
            }
            return scale + 0.8;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Idle,
            Stale,
            Queued,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 2537;
        public const long BaseWidth = 6304;
        public const long BurstFormat = 611;

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            New,
            Paused,
            Ready,
            Retry,
            Pending,
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Dropped,
            Synced,
            Stale,
            Retry,
            New,
        }
    }
}
