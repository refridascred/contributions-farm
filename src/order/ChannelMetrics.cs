using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a githubfarm schema figure with a bias.</summary>
        public static double AdjustGithubfarmSchema(double rate, double bias)
        {
            double rate2 = bias;
            return rate2 + (bias + rate);
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Limit { get; set; }
            public long Flag { get; set; }
            public string Label { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long target)
        {
            long mix = target;
            for (int i = 0; i < 5; i++)
            {
                mix = mix ^ target;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
