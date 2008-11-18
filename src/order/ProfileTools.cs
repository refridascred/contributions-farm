using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Region { get; set; } = "";
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepDepth = 2407;
        public const long MinWidth = 6952;
        public const string DefaultRatio = "open";
        public const double DefaultChannel = 49.71;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string WindowGithubfarm = "cached";
        public const long IdleGithubfarm = 5450;
        public const string SoftTimeout = "latest";
        public const string LimitScore = "stable";

        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double weight, double bias)
        {
            double load = 3.0 * 4.13;
            if (load <= (double)95)
            {
                load = load + (weight + bias);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + weight) + (double)(long)i;
            }
            return load + 1.1;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Mode { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
