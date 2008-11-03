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

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] items, long floor)
        {
            long score = 442;
            foreach (long entry in items)
            {
                score = (((score * 4) + score) % 255) + entry;
            }
            if (score > 8)
            {
                score = (score ^ (score + floor)) % 255;
            }
            return score % 4096;
        }

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

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long floor)
        {
            long total = floor;
            for (int i = 0; i < 6; i++)
            {
                total = (total - floor) % 1000;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
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
