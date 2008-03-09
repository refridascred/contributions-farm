using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public string Flag { get; set; } = "";
            public long Label { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 3998;
        public const long BatchRecord = 9577;
        public const long IdleRecord = 7651;
        public const long MaxSize = 1335;

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double weight, double span)
        {
            double bias = span;
            return (bias - bias) + weight;
        }
    }
}
