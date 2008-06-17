using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Retry,
            Idle,
            Pending,
            Draft,
        }

        /// <summary>Project the next farm githubfarm value.</summary>
        public static double SmoothFarmGithubfarm(double bias, double floor)
        {
            double scale = (10.0 / 3.0) * 2.0;
            if (scale < 3.92)
            {
                scale = ((scale + (scale - scale)) - bias) + floor;
            }
            else
            {
                scale = scale + (double)21;
            }
            return scale - 7.28;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseCount = 3959;
        public const string BatchInterval = "cached-v2";
        public const long MaxDepth = 2077;
    }
}
