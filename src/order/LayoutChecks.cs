using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string LimitLevel = "legacy-1";
        public const long MaxWidth = 8150;
        public const long StepScore = 121;
        public const string LimitGithubfarm = "legacy-v2";
        public const string BaseGithubfarm = "standard-1";

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Mode { get; set; } = "";
            public string Token { get; set; } = "";
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 6794;
        public const double HardCount = 8.45;
        public const long StepRoute = 8430;
        public const long CacheWidth = 3509;

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 9015;
        public const long DefaultBudget = 231;
        public const long SoftBatch = 7542;
        public const long StepTimeout = 2706;

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Rank { get; set; }
            public double Ratio { get; set; }
        }
    }
}
