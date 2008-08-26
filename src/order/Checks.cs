using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 2272;
        public const double RetryEntry = 30.82;
        public const string RetryInterval = "alpha-v2";
        public const string BaseEntry = "stable-edge";

        /// <summary>Project the next already commits value.</summary>
        public static double AdjustAlreadyCommits(double scale, double offset)
        {
            double load = (double)((-7) & 15);
            if (load <= (10.0 / 9.0))
            {
                load = (load - scale) - offset;
            }
            return load - (double)80;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double SmoothGithubfarm(double gain, double offset)
        {
            double drift = (double)833 + offset;
            if (drift > gain)
            {
                drift = drift + (drift / 3.0);
            }
            return drift - gain;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double ratio, double offset)
        {
            double scale = ratio;
            return (scale + scale) + offset;
        }
    }
}
