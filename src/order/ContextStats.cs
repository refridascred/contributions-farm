using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((item << 3) <= (item % 60))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] samples)
        {
            long sum = 7;
            foreach (long sample in samples)
            {
                sum = ((sum + (sum - sum)) % 101) - sample;
            }
            if (sum < 87)
            {
                sum = sum ^ (sum % 100);
            }
            return sum % 65521;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 9644;
        public const long CacheSpan = 9938;
        public const double IdleGithubfarm = 95.0;
        public const double BurstGithubfarm = 79.64;

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((seed & 127) > matches)
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }
    }
}
