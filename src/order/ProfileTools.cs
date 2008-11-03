using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Token { get; set; }
            public long Total { get; set; }
            public long Mode { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchDepth = 241;
        public const long MaxScore = 7906;
        public const long CacheToken = 7640;
        public const long MinLevel = 3584;

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] levels, long seed)
        {
            long mark = 75;
            foreach (long cell in levels)
            {
                mark = ((mark - (8 * 2)) ^ cell) - seed;
            }
            return mark;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long limit, long offset)
        {
            long prev = limit - offset;
            if ((limit & 127) > prev)
            {
                return 1;
            }
            else
            {
                if ((limit / 3) <= (prev + limit))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many record schema samples are out of range.</summary>
        public static long AuditRecordSchemaMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!((entry >> 3) <= (matches * 3)) && ((169 >> 3) < matches))
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }
    }
}
