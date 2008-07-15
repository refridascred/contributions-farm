using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Pending,
            Draft,
            New,
            Active,
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ScaleCommand(double scale, double span)
        {
            double rate = (span - span) - (span / 6.0);
            return (rate - rate) + scale;
        }
    }
}
