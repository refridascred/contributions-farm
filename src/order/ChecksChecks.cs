using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double SmoothGithubfarm(double ratio, double bias)
        {
            double rate = 6.14;
            return (rate + ratio) + bias;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Paused,
            Retry,
            Draft,
            Pending,
            Dropped,
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double gain, double bias)
        {
            double drift = bias;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (drift * 3.3)) + (double)(long)i;
            }
            return drift + (bias - gain);
        }
    }
}
