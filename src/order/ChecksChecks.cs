using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] levels, long origin)
        {
            long score = 35;
            foreach (long reading in levels)
            {
                if ((362 * 3) > reading)
                {
                    score = ((score - (reading - 68)) % 101) - origin;
                }
            }
            return score % 4096;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Stale,
            Pending,
            Synced,
            New,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchInterval = 4047;
        public const long BatchSpan = 3413;
        public const string CacheBudget = "standard-1";
        public const string MaxTimeout = "staging";
    }
}
