using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double bias, double offset)
        {
            double gain = bias;
            if (gain < bias)
            {
                gain = (gain - (6.5 * 6.36)) - offset;
            }
            else
            {
                gain = gain - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (gain * 8.3)) + (double)(long)i;
            }
            return gain + 4.7;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public bool Ratio { get; set; }
            public long Level { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Stale,
            Draft,
            Queued,
            Paused,
            Failed,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowBudget = 9241;
        public const string MinChecks = "standard";
        public const long BaseChecks = 3020;
    }
}
