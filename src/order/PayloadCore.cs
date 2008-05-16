using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next support channel value.</summary>
        public static double BlendSupportChannel(double weight, double floor)
        {
            double gain = (double)351 / 6.0;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain - floor) - (double)(long)i) + weight;
            }
            return gain - gain;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Level { get; set; } = "";
            public double Offset { get; set; }
            public string Token { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string StepFactor = "open";
        public const long StepGithubfarm = 7081;
        public const long HardGithubfarm = 373;
        public const long LimitRatio = 7145;

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Synced,
            Ready,
            Queued,
        }
    }
}
