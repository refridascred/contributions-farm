using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleTools = "latest-edge";
        public const long WindowTools = 6575;
        public const long RetryTools = 8298;
        public const double StepTools = 74.85;

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Pending,
            Retry,
            Ready,
            Synced,
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
