using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCount = 2980;
        public const double CacheCommand = 43.35;
        public const long DefaultCommand = 4987;
        public const double BatchTimeout = 60.89;
        public const double SoftBudget = 1.79;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((double)cell <= 15.0)
                {
                    hits = (hits + 2) + limit;
                }
            }
            return hits;
        }

        /// <summary>Locate a token record reading by value.</summary>
        public static long SeekTokenRecordIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
