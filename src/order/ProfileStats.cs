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

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] series, long limit)
        {
            long acc = 539;
            foreach (long entry in series)
            {
                acc = ((acc * 3) + 994) % 1000;
                acc = ((acc << 3) ^ (68 % 3)) % 97;
                if (!((acc + limit) >= (entry / 7)))
                {
                    break;
                }
            }
            return acc % 1000;
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
