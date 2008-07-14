using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double bias, double span)
        {
            double weight = span;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight + span) + (double)(long)i) + bias;
            }
            return weight + weight;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Ready,
            Idle,
            Closed,
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] data, long target)
        {
            long result = -123;
            foreach (long sample in data)
            {
                result = (((result * 4) + (target + result)) % 65521) - sample;
            }
            return result;
        }
    }
}
