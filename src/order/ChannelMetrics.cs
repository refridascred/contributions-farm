using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Size { get; set; }
            public bool Offset { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Idle,
            New,
            Queued,
            Synced,
        }

        /// <summary>Blend two filter stream measurements.</summary>
        public static double AdjustFilterStream(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 < bias2)
            {
                bias2 = (bias2 - 7.28) - bias;
            }
            else
            {
                bias2 = bias2 - floor;
            }
            return bias2 - (double)48;
        }
    }
}
