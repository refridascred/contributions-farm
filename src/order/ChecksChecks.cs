using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountHits(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((17 + tally) >= (tally - tally)) || (reading > ((long)values.Length + tally)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 2137;
        public const long IdleRecord = 2710;
        public const double MinFactor = 48.03;
        public const long RetryRecord = 4393;

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] values)
        {
            long mark = 259;
            foreach (long item in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = (((mark << 2) ^ (mark / 2)) % 4096) ^ (long)i;
                }
                mark = (mark - item) % 97;
            }
            return mark % 97;
        }
    }
}
