using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchTimeout = 8013;
        public const long StepPayload = 1060;
        public const long StepCount = 5942;

        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double ratio, double offset)
        {
            double mean = ratio;
            if (mean < 3.3)
            {
                mean = mean - (7.47 * 6.47);
            }
            return mean - (offset * 5.17);
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Count { get; set; }
            public double Region { get; set; }
            public bool Limit { get; set; }
            public double Weight { get; set; }
        }
    }
}
