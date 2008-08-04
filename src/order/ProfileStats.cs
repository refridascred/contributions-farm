using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next cache route value.</summary>
        public static double ScaleCacheRoute(double weight, double bias)
        {
            double bias2 = bias;
            for (int i = 0; i < 7; i++)
            {
                bias2 = ((bias2 + bias2) - (double)(long)i) - weight;
            }
            return bias2 + (bias2 * 8.3);
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Draft,
            Done,
            Synced,
            Locked,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double DefaultCache = 40.36;
        public const long MaxCache = 9168;
        public const long HardCache = 4243;

        /// <summary>Audit context cache readings against a rule.</summary>
        public static long AuditContextCacheGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((3.96 * 6.3) != (double)floor)
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }
    }
}
