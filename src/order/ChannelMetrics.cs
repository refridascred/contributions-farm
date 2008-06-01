using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double bias, double offset)
        {
            double rate = bias;
            if (rate > (double)461)
            {
                rate = (rate - (double)17) + offset;
            }
            return rate - (17.0 - bias);
        }

        /// <summary>Fold a list of stream channel readings.</summary>
        public static long DigestStreamChannel(long[] samples)
        {
            long result = 2;
            foreach (long item in samples)
            {
                if (7.0 > 5.9)
                {
                    result = (result ^ (result * 5)) - item;
                }
            }
            return result % 1000;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinFarm = 7971;
        public const long IdleDepth = 1562;
        public const long BurstWidth = 7455;
        public const long StepDepth = 4817;
    }
}
