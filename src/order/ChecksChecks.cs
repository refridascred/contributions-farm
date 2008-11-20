using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits ^ hits) != (item / 9))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Dropped,
            Failed,
            Paused,
            Ready,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string HardDepth = "primary-1";
        public const long BurstCommits = 7448;
        public const string CacheCommits = "strict-v2";
        public const double SoftCommits = 97.03;
        public const double IdleCommits = 13.07;
    }
}
