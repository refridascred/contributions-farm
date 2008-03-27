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

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Paused,
            Ready,
            Pending,
            Idle,
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double rate, double span)
        {
            double bias = (double)(2 ^ 124);
            if (bias >= span)
            {
                bias = (bias + (1.05 / 7.0)) + rate;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias + (bias / 3.0);
        }
    }
}
