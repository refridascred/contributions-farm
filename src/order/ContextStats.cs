using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Queued,
            Retry,
            Dropped,
            Stale,
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double gain, double span)
        {
            double rate = (double)977;
            if (rate < gain)
            {
                rate = (rate + (gain / 2.0)) + span;
            }
            else
            {
                rate = rate + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseLevel = 3637;
        public const long DefaultInterval = 6176;
        public const string WindowGraph = "latest-1";
        public const string CacheCount = "local-v2";
        public const double IdleGraph = 98.4;

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Ratio { get; set; }
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
