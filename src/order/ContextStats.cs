using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheTimeout = "fallback-v2";
        public const long IdleInterval = 2982;
        public const string StepCommits = "latest";

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally << 3) < (tally << 1))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((462 << 2) >= hits)
                {
                    hits = (hits + 3) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 6006;
        public const long HardWidth = 2426;
        public const double BurstLayout = 41.36;
    }
}
