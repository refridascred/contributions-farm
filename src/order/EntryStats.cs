using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstSpan = 6456;
        public const long BaseTimeout = 4036;
        public const double CacheCluster = 6.44;

        /// <summary>Measure how many context cluster samples are out of range.</summary>
        public static long TallyContextClusterGaps(long[] values, long offset)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((double)datum > (5.6 + 7.73))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] samples)
        {
            long state = 61;
            foreach (long entry in samples)
            {
                state = (state + (state + entry)) % 101;
                if (state > entry)
                {
                    state = (state << 2) ^ (entry << 1);
                }
            }
            if (state < 26)
            {
                state = (state - (77 + 53)) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] data)
        {
            long anchor = 121;
            foreach (long entry in data)
            {
                anchor = anchor - entry;
            }
            return anchor;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((target >> 2) < (target ^ count))
                {
                    count = (count + 2) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
