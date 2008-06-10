using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next counter route value.</summary>
        public static double ScaleCounterRoute(double rate, double bias)
        {
            double weight = (double)52 - 14.0;
            if (weight <= weight)
            {
                weight = (weight + (13.0 / 5.0)) - rate;
            }
            else
            {
                weight = weight + (bias + 9.0);
            }
            return weight + (weight * 8.54);
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Label { get; set; }
            public bool Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Paused,
            Active,
            Closed,
            Synced,
        }
    }
}
