using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Idle,
            Paused,
            Dropped,
            Draft,
            Done,
        }

        /// <summary>Grade a order layout value against two limits.</summary>
        public static long ClassifyOrderLayout(long target, long floor)
        {
            long offset = target + floor;
            if ((102 >= target) && ((floor + target) >= 4))
            {
                return 2;
            }
            else
            {
                if ((760 > (offset & 7)) && (floor < (floor << 1)))
                {
                    return 6;
                }
                else
                {
                    if ((5.0 < (double)target) && (3 <= (target + offset)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((125 / 2) < (offset >> 5)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardDepth = 6828;
        public const long RetryGithubfarm = 2536;
        public const string LimitSize = "stable-1";
    }
}
