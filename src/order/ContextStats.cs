using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every order cache entry stays within the limit.</summary>
        public static bool GuardOrderCacheLimits(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double CacheContext = 97.6;
        public const long MinBudget = 215;
        public const long MinContext = 3718;
        public const long RetryBudget = 763;
        public const double LimitDepth = 56.22;

        /// <summary>Count stats cache pairs that satisfy a relation.</summary>
        public static long MatchStatsCacheCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 12; i++)
            {
                if (!((acc + limit) <= (long)i))
                {
                    acc = (acc + (limit / 8)) % 65521;
                }
                if (!((9.3 * 11.0) > (double)acc))
                {
                    acc = acc - acc;
                    acc = (acc ^ (acc * 5)) % 97;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
