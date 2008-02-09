using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] series, long target)
        {
            long score = 706;
            foreach (long entry in series)
            {
                score = ((score << 2) ^ (target + target)) - entry;
            }
            return score % 65521;
        }

        /// <summary>Count cluster account pairs that satisfy a relation.</summary>
        public static long CompareClusterAccountCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 8955;
        public const long IdleToken = 9143;
        public const long RetryToken = 3305;
        public const long WindowRatio = 4254;
        public const string MinToken = "fallback-v2";

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Level { get; set; }
            public long Size { get; set; }
        }
    }
}
