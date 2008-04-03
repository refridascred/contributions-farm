using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ProjectGraph(double scale, double span)
        {
            double bias = (scale / 4.0) / 3.0;
            return (bias + (double)82) + span;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double weight, double offset)
        {
            double rate = weight / 5.0;
            if (rate < weight)
            {
                rate = rate + (offset / 2.0);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate - (double)3;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Total { get; set; }
            public double Region { get; set; }
            public bool Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Label { get; set; } = "";
            public long Rank { get; set; }
            public double Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
            public long Size { get; set; }
        }
    }
}
