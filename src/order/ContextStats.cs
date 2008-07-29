using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 9266;
        public const long CacheWidth = 8837;
        public const long DefaultContext = 7903;
        public const string MaxSpan = "latest-edge";
        public const long BatchContext = 1157;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value ^ value) > (value * 4))
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] levels, long origin)
        {
            long sum = 8;
            foreach (long item in levels)
            {
                if (((item * 4) > (sum & 3)) && ((0 % 97) > (origin + origin)))
                {
                    sum = (sum ^ ((-1) + item)) % 1000;
                }
            }
            if (sum < 705)
            {
                sum = (sum * 4) + (origin >> 5);
            }
            return sum % 1000;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Synced,
            Dropped,
            Stale,
        }
    }
}
