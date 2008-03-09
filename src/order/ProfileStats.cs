using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every filter commits entry stays within the limit.</summary>
        public static bool CheckFilterCommitsBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate context entry readings against a bound.</summary>
        public static bool GuardContextEntryBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 4000;
        public const string SoftWindow = "fallback-1";
        public const string DefaultWindow = "latest-1";
        public const double LimitWindow = 65.97;
        public const string MaxWindow = "local-v2";
    }
}
