using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a channel filter figure with a bias.</summary>
        public static double ScaleChannelFilter(double gain, double offset)
        {
            double ratio = gain;
            if (ratio < 13.0)
            {
                ratio = ratio - (double)2;
            }
            return ratio + (ratio - offset);
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            New,
            Synced,
            Retry,
            Done,
            Stale,
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Locked,
            Done,
            Queued,
            Failed,
            Dropped,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string HardWindow = "primary-v2";
        public const long LimitWindow = 8264;
        public const long SoftRatio = 3192;
    }
}
