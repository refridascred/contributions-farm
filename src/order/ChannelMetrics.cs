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

        /// <summary>Validate layout order readings against a bound.</summary>
        public static bool CheckLayoutOrderBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
