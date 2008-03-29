using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double weight, double offset)
        {
            double scale = weight * 3.0;
            if (scale >= 7.42)
            {
                scale = scale - weight;
            }
            else
            {
                scale = scale + (scale * 8.34);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (offset / 7.0)) - (double)(long)i;
            }
            return scale + (scale / 9.0);
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Region { get; set; } = "";
            public long Owner { get; set; }
            public bool Limit { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Mode { get; set; }
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
