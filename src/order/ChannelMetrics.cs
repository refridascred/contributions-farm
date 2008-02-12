using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double MinFactor = 3.17;
        public const long StepEditor = 2879;
        public const long StepSpan = 4357;

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitWidth = 7907;
        public const double CacheFactor = 61.24;
        public const string DefaultInterval = "legacy";
        public const long HardRatio = 8048;

        /// <summary>Blend two schema githubfarm measurements.</summary>
        public static double AdjustSchemaGithubfarm(double weight, double offset)
        {
            double bias = offset;
            return (bias + (double)919) + weight;
        }
    }
}
