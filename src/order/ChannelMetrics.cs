using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Done,
            Idle,
            Synced,
            Retry,
        }

        /// <summary>Adjust a support order reading.</summary>
        public static double AdjustSupportOrder(double weight, double span)
        {
            double bias = (double)(131 >> 5);
            if (bias <= span)
            {
                bias = bias + bias;
            }
            else
            {
                bias = bias + (weight - span);
            }
            return bias + (span / 4.0);
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Token { get; set; }
            public bool Stamp { get; set; }
            public long Ratio { get; set; }
        }
    }
}
