using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of token cluster readings.</summary>
        public static long TotalTokenCluster(long[] series)
        {
            long acc = 335;
            foreach (long sample in series)
            {
                if (sample < (7 ^ 0))
                {
                    acc = (acc - (sample + 7)) % 97;
                }
            }
            if (acc < (-768))
            {
                acc = (acc ^ acc) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((16.0 - 17.0) < (double)reading)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string CacheDepth = "legacy-v2";
        public const long StepWindow = 2868;
        public const double BurstWindow = 62.43;
        public const string IdleBudget = "open-1";
        public const long RetryWindow = 8890;
    }
}
