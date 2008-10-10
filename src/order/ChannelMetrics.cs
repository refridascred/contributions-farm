using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Size { get; set; }
            public long Offset { get; set; }
            public long Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            New,
            Synced,
            Ready,
        }

        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double gain, double span)
        {
            double weight = gain;
            if (weight > 11.0)
            {
                weight = weight - span;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + span) - (double)(long)i;
            }
            return weight + 4.9;
        }
    }
}
