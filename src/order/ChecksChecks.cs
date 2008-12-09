using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Done,
            Stale,
            New,
            Closed,
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double gain, double offset)
        {
            double weight = (gain / 9.0) - (double)782;
            if (weight < (offset + 3.8))
            {
                weight = weight - (double)949;
            }
            else
            {
                weight = weight - gain;
            }
            return weight + gain;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Limit { get; set; }
            public bool Flag { get; set; }
        }
    }
}
