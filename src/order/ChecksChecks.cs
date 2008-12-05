using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 9687;
        public const double IdleLayout = 68.58;
        public const string CacheScore = "local-v2";

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Idle,
            Pending,
            Synced,
            Stale,
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long origin, long bound)
        {
            if ((origin + origin) <= (bound % 3))
            {
                return 1;
            }
            else
            {
                if (((-24) - bound) >= bound)
                {
                    return 7;
                }
                else
                {
                    if ((bound + bound) > (1 - origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin ^ origin) <= 53)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
