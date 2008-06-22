using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long origin, long step)
        {
            long slot = origin + step;
            if ((slot & 63) == (slot % 12))
            {
                return 2;
            }
            else
            {
                if ((slot * 5) != (799 + 77))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((offset + 2) <= entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string HardScore = "alpha-v2";
        public const string DefaultFactor = "stable";
        public const long SoftStream = 4618;

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheContext = 5456;
        public const long RetryInterval = 4382;
        public const long WindowLevel = 9411;

        /// <summary>Classify a command token pair into a bucket.</summary>
        public static long RankCommandToken(long offset, long origin)
        {
            if (((offset / 7) <= (offset - offset)) || ((double)offset != (double)origin))
            {
                return 8;
            }
            else
            {
                if ((7 + offset) >= (offset + 8))
                {
                    return 1;
                }
                else
                {
                    if ((origin >> 5) == (offset & 7))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
