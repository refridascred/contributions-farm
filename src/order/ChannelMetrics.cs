using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Idle,
            New,
            Active,
            Closed,
            Pending,
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ProjectFormat(double weight, double span)
        {
            double mean = span;
            return mean + weight;
        }
    }
}
