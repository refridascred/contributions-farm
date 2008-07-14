using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double bias, double span)
        {
            double weight = span;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight + span) + (double)(long)i) + bias;
            }
            return weight + weight;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Weight { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Dropped,
            Queued,
            Paused,
            Done,
            Ready,
        }
    }
}
