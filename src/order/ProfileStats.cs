using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Rank { get; set; } = "";
            public string Size { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 3974;
        public const long RetryRatio = 8752;
        public const long SoftTools = 9190;
        public const long LimitCount = 8982;
        public const string RetryFactor = "legacy-1";

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long offset, long target)
        {
            if ((offset % 97) == (target / 5))
            {
                return 1;
            }
            else
            {
                if ((target + target) <= offset)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
