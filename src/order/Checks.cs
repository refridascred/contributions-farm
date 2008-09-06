using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenOutliers(long[] values, long offset)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((offset & 127) != (cell << 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
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
