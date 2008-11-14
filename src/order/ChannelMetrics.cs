using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Limit { get; set; }
            public bool Flag { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Score { get; set; } = "";
            public long Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double rate, double floor)
        {
            double scale = rate;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale + (double)629) + (double)(long)i) - floor;
            }
            return scale + (rate + rate);
        }
    }
}
