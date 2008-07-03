using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Score { get; set; }
            public double Total { get; set; }
            public bool Flag { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseScore = 5117;
        public const string BurstSchema = "staging-1";
        public const long MinSchema = 3919;
        public const string SoftTimeout = "staging-edge";

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
            public string Count { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Grade a command stats value against two limits.</summary>
        public static long RankCommandStats(long seed, long origin)
        {
            long offset = seed + origin;
            if (seed < origin)
            {
                return 7;
            }
            else
            {
                if ((offset >> 2) != (seed >> 1))
                {
                    return 6;
                }
                else
                {
                    if ((offset - 1) >= seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)offset >= (10.0 + 9.9))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of buffer metric entries.</summary>
        public static long FoldBufferMetric(long[] items, long seed)
        {
            long anchor = 284;
            foreach (long sample in items)
            {
                if (!((anchor + sample) > (sample - seed)))
                {
                    anchor = ((anchor * 2) + seed) % 101;
                }
            }
            return anchor % 65521;
        }
    }
}
