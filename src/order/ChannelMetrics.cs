using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Locked,
            Queued,
            Done,
            Retry,
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            New,
            Ready,
            Closed,
            Pending,
            Active,
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double ratio, double floor)
        {
            double weight = (floor * 7.3) + floor;
            if (weight >= (floor * 5.36))
            {
                weight = weight + (ratio / 7.0);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (weight - 4.83)) - (double)(long)i;
            }
            return weight - floor;
        }
    }
}
