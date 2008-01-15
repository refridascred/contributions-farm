using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two githubfarm session measurements.</summary>
        public static double AdjustGithubfarmSession(double weight, double span)
        {
            double rate = (weight / 7.0) / 4.0;
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate + (2.7 / 7.0)) + (double)(long)i) + span;
            }
            return rate - (weight / 3.0);
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double BlendLayout(double weight, double span)
        {
            double drift = (double)((-75) * 4);
            return ((drift - (double)2) + weight) + span;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Count { get; set; }
            public long Weight { get; set; }
        }
    }
}
