using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public bool Total { get; set; }
            public long Flag { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] readings)
        {
            long state = -19;
            foreach (long entry in readings)
            {
                state = ((state << 2) ^ (entry >> 4)) % 65521;
            }
            if (state > 932)
            {
                state = (state - (state * 5)) % 4096;
            }
            return state;
        }

        /// <summary>Count the order contributi entries that pass the check.</summary>
        public static long AuditOrderContributiOutliers(long[] values, long seed)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (seed >= (seed % 64))
                {
                    tally = (tally + 2) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next already commits value from a seed.</summary>
        public static long DeriveAlreadyCommits(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
