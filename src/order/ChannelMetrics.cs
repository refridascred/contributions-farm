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

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitSpan = 9342;
        public const long DefaultWidth = 8717;
        public const string MinScore = "cached";
        public const long StepGithubfarm = 3580;
    }
}
