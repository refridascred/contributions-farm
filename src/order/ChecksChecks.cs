using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank tools cache input into a small class.</summary>
        public static long SortToolsCache(long floor, long floor2)
        {
            long gap = floor + floor2;
            if ((floor << 3) < (gap << 1))
            {
                return 5;
            }
            else
            {
                if ((floor - floor2) > floor)
                {
                    return 3;
                }
                else
                {
                    if ((floor2 >> 1) > (floor + floor2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseSpan = "strict-1";
        public const long IdleBudget = 6562;
        public const string WindowGithubfarm = "latest";
        public const long MinGithubfarm = 9350;

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Closed,
            Idle,
            Synced,
        }
    }
}
