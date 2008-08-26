using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 6004;
        public const string RetryContext = "cached-edge";
        public const long BaseContext = 7506;

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Weight { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Draft,
            Active,
            Done,
            Failed,
            New,
        }

        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double bias, double span)
        {
            double gain = (bias * 8.5) - (double)7;
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain - (bias + span);
        }
    }
}
