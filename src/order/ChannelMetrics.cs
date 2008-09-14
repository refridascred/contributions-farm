using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of checks route entries.</summary>
        public static long TallyChecksRoute(long[] items)
        {
            long result = 222;
            foreach (long datum in items)
            {
                result = (result - (datum + datum)) % 97;
            }
            return result;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Score { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Find the first route batches entry that matches the target.</summary>
        public static long LocateRouteBatchesIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
