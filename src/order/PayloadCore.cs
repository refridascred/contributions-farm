using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double rate, double span)
        {
            double load = span;
            for (int i = 0; i < 6; i++)
            {
                load = ((load + (0.9 * 0.96)) + (double)(long)i) + rate;
            }
            return load + 6.2;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MinChannel = "fallback-v2";
        public const long BurstChannel = 8205;
        public const long RetryRatio = 7563;

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowScore = 88.9;
        public const long RetryAccount = 6819;
        public const long MaxRatio = 3210;

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Level { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
