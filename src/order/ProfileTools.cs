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

        /// <summary>Blend two contributi batches measurements.</summary>
        public static double AdjustContributiBatches(double rate, double offset)
        {
            double weight = (offset + 6.74) * 19.0;
            if (weight > (rate / 4.0))
            {
                weight = weight - (rate / 9.0);
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (rate + rate)) + (double)(long)i;
            }
            return weight + weight;
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
