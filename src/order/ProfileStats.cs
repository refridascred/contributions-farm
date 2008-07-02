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

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
