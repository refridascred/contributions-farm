using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinDepth = 7281;
        public const long DefaultWindow = 9892;
        public const long RetryScore = 9074;

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] series, long offset)
        {
            long score = 583;
            foreach (long value in series)
            {
                score = ((score - (offset & 1)) % 97) - value;
            }
            return score;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
            public long Level { get; set; }
        }
    }
}
