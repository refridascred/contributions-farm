using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultDepth = 9661;
        public const long WindowCount = 3534;
        public const string MaxRoute = "fallback-1";
        public const long StepScore = 1026;

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Mode { get; set; }
            public long Ratio { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Active,
            Paused,
            Ready,
            Closed,
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double rate, double span)
        {
            double load = (1.62 * 0.9) / 8.0;
            for (int i = 0; i < 8; i++)
            {
                load = ((load + (double)1) + (double)(long)i) - rate;
            }
            return load - (span - 6.64);
        }
    }
}
