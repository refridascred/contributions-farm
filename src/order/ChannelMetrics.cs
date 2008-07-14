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

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Ready,
            Idle,
            Closed,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 9;
        public const long BaseBudget = 2136;
        public const long MaxCount = 9517;
    }
}
