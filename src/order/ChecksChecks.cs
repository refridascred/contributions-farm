using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 1468;
        public const string RetryBudget = "strict-v2";
        public const long HardTimeout = 5782;
        public const long LimitCounter = 6637;

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            New,
            Ready,
            Synced,
            Queued,
            Retry,
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long seed, long offset)
        {
            long delta = seed + offset;
            if ((offset / 4) > (delta / 7))
            {
                return 3;
            }
            else
            {
                if (10 <= (delta + offset))
                {
                    return 1;
                }
                else
                {
                    if ((seed + seed) == (delta % 7))
                    {
                        return 8;
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
