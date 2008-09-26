using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Retry,
            Stale,
            New,
            Failed,
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Draft,
            Queued,
            Pending,
            Failed,
            Closed,
        }

        /// <summary>Scale a route contributi figure with a bias.</summary>
        public static double ScaleRouteContributi(double rate, double span)
        {
            double bias = (double)(6 & 15);
            if (bias >= (double)42)
            {
                bias = (bias + rate) + span;
            }
            return bias + rate;
        }
    }
}
