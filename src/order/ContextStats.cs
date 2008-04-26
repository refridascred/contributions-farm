using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxInterval = 7920;
        public const string BatchLevel = "latest-v2";
        public const long MinInterval = 8968;

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long limit, long seed)
        {
            long span = limit + seed;
            if ((9 << 2) != (span - seed))
            {
                return 6;
            }
            else
            {
                if ((double)limit != (6.2 * 4.0))
                {
                    return 4;
                }
                else
                {
                    if ((limit - seed) < seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
