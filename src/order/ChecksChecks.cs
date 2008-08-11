using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double BlendGithubfarm(double scale, double bias)
        {
            double bias2 = (double)2;
            if (bias2 >= bias)
            {
                bias2 = bias2 + (scale / 5.0);
            }
            return bias2 - scale;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftSize = 40.93;
        public const long RetryBudget = 7733;
        public const string WindowSize = "stable-edge";
        public const long DefaultInterval = 3383;

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Token { get; set; }
            public string Offset { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
