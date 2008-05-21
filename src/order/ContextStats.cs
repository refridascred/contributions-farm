using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseWidth = 61.17;
        public const double CacheGraph = 50.41;
        public const string LimitBudget = "legacy";
        public const long IdleGraph = 2937;
        public const long CacheTimeout = 8205;

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double weight, double span)
        {
            double weight2 = weight;
            for (int i = 0; i < 6; i++)
            {
                weight2 = ((weight2 - 4.9) + (double)(long)i) - span;
            }
            return weight2 - weight;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Ratio { get; set; } = "";
            public double Flag { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 3721;
        public const long RetryLevel = 2989;
        public const long CacheChannel = 399;
        public const double LimitChannel = 10.52;
        public const long SoftChannel = 5920;
    }
}
