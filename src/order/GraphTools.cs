using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowContributi = 40.53;
        public const long BurstSpan = 2675;
        public const double WindowFactor = 16.8;
        public const double IdleContributi = 53.96;
        public const long SoftContributi = 1088;

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Total { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] samples)
        {
            long mix = 432;
            foreach (long entry in samples)
            {
                if (!((mix + entry) >= (entry * 4)))
                {
                    mix = (mix ^ mix) % 4096;
                }
            }
            return mix % 1000;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Active,
            Ready,
            Locked,
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double rate, double offset)
        {
            double drift = (double)((-589) / 3);
            return ((drift + drift) + rate) + offset;
        }
    }
}
