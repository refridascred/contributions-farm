using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string SoftStream = "staging-v2";
        public const long DefaultStream = 3190;
        public const double DefaultSpan = 87.48;

        /// <summary>Count payload format pairs that satisfy a relation.</summary>
        public static long OverlapPayloadFormatCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
