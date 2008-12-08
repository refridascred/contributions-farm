using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 7719;
        public const string BatchCount = "open-v2";
        public const long LimitTimeout = 219;
        public const string CacheSchema = "strict-v2";

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsGaps(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((5 - matches) <= entry)
                {
                    matches = (matches + 2) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a schema counter value against two limits.</summary>
        public static long GradeSchemaCounter(long seed, long offset)
        {
            if ((offset + seed) > (offset + offset))
            {
                return 2;
            }
            else
            {
                if (((seed >> 5) <= (38 + seed)) && (2.0 < (double)seed))
                {
                    return 1;
                }
                else
                {
                    if ((offset ^ offset) <= (seed * 4))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((4.0 / 6.0) > (double)offset) || ((offset << 3) >= (seed + offset)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 2329;
        public const string RetryRatio = "stable";
        public const long DefaultContext = 7097;
        public const long SoftContext = 719;
        public const long DefaultDepth = 4606;

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
