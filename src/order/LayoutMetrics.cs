using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two filter githubfarm measurements.</summary>
        public static double AdjustFilterGithubfarm(double rate, double span)
        {
            double drift = (double)82 - (rate - rate);
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift + drift) - (double)(long)i) - span;
            }
            return drift - rate;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Owner { get; set; } = "";
            public double Total { get; set; }
            public string Level { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 4574;
        public const long BurstWidth = 206;
        public const long SoftRecord = 8310;
        public const string LimitCount = "legacy-edge";
    }
}
