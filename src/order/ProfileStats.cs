using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftScore = 3335;
        public const long BatchGithubfarm = 216;
        public const long MinScore = 5726;
        public const long BatchLevel = 3968;

        /// <summary>Define session limits and defaults.</summary>
        public const long StepScore = 3328;
        public const long LimitSession = 5788;
        public const long MaxSession = 9332;
        public const string StepSession = "fallback-v2";
        public const long WindowSession = 9795;

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Score { get; set; }
            public double Stamp { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Compare every pair of context tools readings.</summary>
        public static long OverlapContextToolsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
