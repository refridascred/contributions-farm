using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Blend two command cluster measurements.</summary>
        public static double BlendCommandCluster(double rate, double bias)
        {
            double gain = bias / 9.0;
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + rate) - (double)(long)i;
            }
            return gain - (5.66 + gain);
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Done,
            Draft,
            Ready,
            Idle,
        }
    }
}
