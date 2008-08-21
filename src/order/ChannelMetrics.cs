using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Label { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Synced,
            Draft,
            Idle,
        }

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double gain, double span)
        {
            double drift = gain * 3.5;
            return drift - (span + gain);
        }
    }
}
