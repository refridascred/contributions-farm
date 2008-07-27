using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Active,
            Retry,
            Locked,
            Draft,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderMatches(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((double)entry != (6.07 / 5.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
        }
    }
}
