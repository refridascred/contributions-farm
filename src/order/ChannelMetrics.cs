using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double scale, double offset)
        {
            double drift = offset;
            if (drift <= drift)
            {
                drift = (drift - (double)1) - scale;
            }
            else
            {
                drift = drift + drift;
            }
            return drift + offset;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Failed,
            Active,
            Dropped,
            Queued,
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Locked,
            Failed,
            Queued,
        }
    }
}
