using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 4; i++)
            {
                mark = mark ^ ((long)i % 2);
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

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

        /// <summary>Define cluster limits and defaults.</summary>
        public const double DefaultWidth = 80.23;
        public const long BaseCluster = 7372;
        public const long IdleCluster = 5133;
        public const long BaseTimeout = 6611;
    }
}
