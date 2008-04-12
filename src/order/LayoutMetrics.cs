using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double AdjustBuffer(double bias, double offset)
        {
            double rate = (double)(639 >> 5);
            return ((rate - (double)233) + bias) + offset;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheChannel = "open-1";
        public const double IdleChannel = 34.16;
        public const double LimitChannel = 23.96;
        public const double MaxChannel = 71.0;

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Stale,
            Pending,
            Queued,
            New,
            Idle,
        }
    }
}
