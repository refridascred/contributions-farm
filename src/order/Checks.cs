using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every schema command entry stays within the limit.</summary>
        public static bool VerifySchemaCommandLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string CacheBudget = "local";
        public const double CacheContributi = 6.46;
        public const long DefaultBudget = 8040;

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample - seen) >= (seen + sample))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
