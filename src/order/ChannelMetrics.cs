using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double bias, double offset)
        {
            double weight = offset;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight - (offset - 1.23)) + (double)(long)i) - bias;
            }
            return weight + (weight + weight);
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Count { get; set; }
            public long Level { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Scale a stats cluster figure with a bias.</summary>
        public static double ProjectStatsCluster(double ratio, double bias)
        {
            double load = bias;
            if (load >= (double)52)
            {
                load = (load + (double)9) - ratio;
            }
            else
            {
                load = load + (double)9;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (double)855) - (double)(long)i;
            }
            return load - bias;
        }
    }
}
