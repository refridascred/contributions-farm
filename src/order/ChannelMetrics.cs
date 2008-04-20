using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            New,
            Active,
            Failed,
            Queued,
        }

        /// <summary>Project the next commits channel value.</summary>
        public static double ScaleCommitsChannel(double scale, double bias)
        {
            double load = scale / 4.0;
            return load + bias;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Locked,
            Ready,
            Active,
            Synced,
            Queued,
        }
    }
}
