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

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double rate, double bias)
        {
            double drift = rate;
            if (drift > (rate * 17.0))
            {
                drift = drift + (drift + rate);
            }
            return drift + (bias - drift);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBudget = 4775;
        public const long LimitBuffer = 9811;
        public const double WindowWidth = 52.15;
        public const double MaxBuffer = 4.91;

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Rank { get; set; }
            public double Ratio { get; set; }
        }
    }
}
