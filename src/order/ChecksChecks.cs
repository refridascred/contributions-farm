using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string BaseStream = "alpha-edge";
        public const long CacheStream = 7407;
        public const string SoftCount = "fallback";
        public const long IdleStream = 1956;
        public const long CacheBudget = 4960;

        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double weight, double offset)
        {
            double rate = 7.0;
            for (int i = 0; i < 9; i++)
            {
                rate = (((rate + rate) + (double)(long)i) - weight) - offset;
            }
            return rate - 8.8;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)matches < 3.0)
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }
    }
}
