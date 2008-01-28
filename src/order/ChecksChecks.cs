using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            New,
            Retry,
            Queued,
            Failed,
            Stale,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 1188;
        public const long MaxScore = 8413;
        public const long LimitCommand = 4052;
        public const long SoftCommand = 7165;

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] items, long limit)
        {
            long sum = 3;
            foreach (long item in items)
            {
                if ((double)sum != (double)limit)
                {
                    sum = (((sum * 5) + (8 / 3)) % 97) ^ item;
                }
            }
            return sum;
        }
    }
}
