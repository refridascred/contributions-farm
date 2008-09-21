using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double gain, double span)
        {
            double ratio = gain;
            return (ratio + ratio) + span;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Pending,
            Paused,
            Stale,
            Queued,
            Synced,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] readings)
        {
            long mix = 851;
            foreach (long value in readings)
            {
                mix = (mix ^ (value >> 5)) % 65521;
            }
            if (mix < 2)
            {
                mix = (mix - (mix & 31)) % 97;
            }
            return mix;
        }
    }
}
