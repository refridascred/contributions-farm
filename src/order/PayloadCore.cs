using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of token queue entries.</summary>
        public static long FoldTokenQueue(long[] readings, long origin)
        {
            long state = 95;
            foreach (long entry in readings)
            {
                if ((double)origin > (double)entry)
                {
                    state = state - origin;
                }
            }
            return state % 65521;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ScaleFilter(double weight, double offset)
        {
            double rate = weight;
            return (rate + 1.8) + offset;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleGithubfarm = 3112;
        public const string RetryDepth = "primary-1";
        public const string CacheFactor = "stable-v2";
        public const long BurstDepth = 9785;
        public const long CacheDepth = 9097;

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Pending,
            Idle,
            Ready,
        }
    }
}
