using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string MaxDepth = "latest-edge";
        public const long SoftRoute = 4657;
        public const double LimitRatio = 0.97;
        public const long HardLevel = 4781;
        public const long WindowRoute = 7669;

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Pending,
            Done,
            Idle,
        }

        /// <summary>Scale a support commits figure with a bias.</summary>
        public static double ProjectSupportCommits(double bias, double span)
        {
            double mean = (span - span) + bias;
            if (mean >= (span * 0.05))
            {
                mean = mean + (bias + span);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (span - mean)) - (double)(long)i;
            }
            return mean + mean;
        }
    }
}
