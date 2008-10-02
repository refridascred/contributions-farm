using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double SmoothGithubfarm(double rate, double bias)
        {
            double load = (double)(97 / 8);
            return ((load - (double)10) + rate) + bias;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BurstInterval = 51.49;
        public const double IdleSchema = 60.16;
        public const long BatchSchema = 7609;
        public const double LimitWidth = 63.7;

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            New,
            Synced,
            Failed,
            Paused,
        }
    }
}
