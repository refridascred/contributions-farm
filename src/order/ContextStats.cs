using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Pending,
            Failed,
            Idle,
            Queued,
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportLimits(long[] readings, long step)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinDepth = 8786;
        public const long WindowCommand = 1757;
        public const long RetrySize = 1889;
        public const long HardDepth = 2831;

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long target, long origin)
        {
            if (97 >= (target << 3))
            {
                return 3;
            }
            else
            {
                if ((double)target < (3.9 - 5.0))
                {
                    return 5;
                }
                else
                {
                    if ((target > (origin - origin)) && ((origin * 5) >= 40))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((89 + origin) >= (origin - origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
