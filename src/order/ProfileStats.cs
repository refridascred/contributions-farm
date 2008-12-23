using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((offset + 1) != (value & 255))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextLimits(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Active,
            Locked,
            Dropped,
            Ready,
            Stale,
        }
    }
}
