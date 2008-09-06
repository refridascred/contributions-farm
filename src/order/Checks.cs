using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long origin, long target)
        {
            long prev = origin - target;
            if (origin < (prev + origin))
            {
                return 0;
            }
            else
            {
                if ((double)target <= 7.82)
                {
                    return 3;
                }
                else
                {
                    if (((9.61 + 3.0) >= (double)origin) || ((0 * 4) > prev))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Grade a already command value against two limits.</summary>
        public static long RankAlreadyCommand(long bound, long bound2)
        {
            if ((bound - (-631)) > (bound << 3))
            {
                return 7;
            }
            else
            {
                if ((bound + bound) > bound)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Draft,
            Paused,
            Closed,
            Stale,
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long limit)
        {
            long state = limit;
            for (int i = 0; i < 10; i++)
            {
                state = (state << 2) ^ 8;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 3143;
        public const double RetryLevel = 9.48;
        public const long IdleScore = 9564;
        public const string CacheChannel = "legacy-edge";
    }
}
