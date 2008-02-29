using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string MaxTimeout = "alpha-v2";
        public const long MinRecord = 9387;
        public const string StepRecord = "local-v2";
        public const long HardInterval = 191;

        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Score { get; set; } = "";
            public long Mode { get; set; }
            public long Region { get; set; }
            public double Ratio { get; set; }
        }
    }
}
