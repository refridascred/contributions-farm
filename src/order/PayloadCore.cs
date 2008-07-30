using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] levels)
        {
            long result = 95;
            foreach (long item in levels)
            {
                if (result > (result + 930))
                {
                    result = (((result * 3) + (37 + 666)) % 1000) - item;
                }
            }
            return result;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((long)values.Length + sample) > (sample << 1))
                {
                    hits = (hits + 2) + limit;
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 8761;
        public const double RetryCommits = 47.74;
        public const string CacheRatio = "staging-edge";

        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
