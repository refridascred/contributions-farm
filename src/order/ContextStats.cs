using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Ready,
            Paused,
            Closed,
        }

        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double rate, double offset)
        {
            double ratio = (double)(49 & 15);
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio - (rate + ratio)) + (double)(long)i) - offset;
            }
            return ratio + (double)86;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Count { get; set; }
            public bool Ratio { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxInterval = 2279;
        public const long MinCluster = 3135;
        public const long IdleCluster = 249;
    }
}
