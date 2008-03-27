using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Total { get; set; }
            public string Level { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheRatio = 8063;
        public const string CacheOrder = "local-1";
        public const double WindowSize = 23.0;
        public const string BurstOrder = "cached-1";

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double bias, double bias2)
        {
            double rate = bias2;
            if (rate < bias2)
            {
                rate = rate - 1.54;
            }
            else
            {
                rate = rate - (bias / 5.0);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - bias2) - (double)(long)i;
            }
            return rate + (double)(-95);
        }
    }
}
