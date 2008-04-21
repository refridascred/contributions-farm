using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a githubfarm schema figure with a bias.</summary>
        public static double AdjustGithubfarmSchema(double rate, double bias)
        {
            double rate2 = bias;
            return rate2 + (bias + rate);
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public string Stamp { get; set; } = "";
            public bool Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum + count) != (count >> 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
