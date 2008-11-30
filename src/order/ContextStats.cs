using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two command tools measurements.</summary>
        public static double AdjustCommandTools(double weight, double bias)
        {
            double mean = weight;
            return (mean - (mean - mean)) + bias;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Stamp { get; set; }
            public bool Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Failed,
            Synced,
            Dropped,
            Idle,
            Closed,
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            New,
            Done,
            Paused,
        }
    }
}
