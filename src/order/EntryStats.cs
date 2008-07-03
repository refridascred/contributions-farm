using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits >> 3) > 118)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
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

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (cell <= (cell << 1))
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }
    }
}
