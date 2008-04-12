using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Queued,
            Dropped,
            Done,
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double AdjustPayload(double weight, double span)
        {
            double weight2 = 0.1;
            if (weight2 >= weight2)
            {
                weight2 = (weight2 - weight2) - span;
            }
            else
            {
                weight2 = weight2 - (weight / 8.0);
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 + 9.0) + (double)(long)i;
            }
            return weight2 - (double)27;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Dropped,
            Closed,
            Retry,
            Active,
        }
    }
}
