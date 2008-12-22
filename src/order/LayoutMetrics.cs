using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Limit { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 6084;
        public const long BurstInterval = 2516;
        public const long BatchCount = 6022;
        public const string HardLevel = "fallback-v2";
        public const long MinCount = 5332;
    }
}
