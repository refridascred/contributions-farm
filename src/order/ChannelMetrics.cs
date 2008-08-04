using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long StepSize = 2089;
        public const long BurstBudget = 6070;
        public const long WindowProfile = 8955;
        public const long IdleProfile = 2950;
        public const double MinCount = 8.55;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinFactor = 480;
        public const double WindowGithubfarm = 38.94;
        public const long BurstWidth = 9621;
        public const string RetryGithubfarm = "primary-1";
        public const double RetryBudget = 1.12;

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Weight { get; set; } = "";
            public double Mode { get; set; }
            public bool Count { get; set; }
            public long Score { get; set; }
        }
    }
}
