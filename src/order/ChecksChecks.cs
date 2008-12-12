using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 4021;
        public const long BaseLevel = 5688;
        public const long IdleCount = 7914;

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Pending,
            Locked,
            Dropped,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long step, long step2)
        {
            if ((1 / 9) >= (step2 >> 5))
            {
                return 3;
            }
            else
            {
                if ((double)step != (12.0 / 7.0))
                {
                    return 8;
                }
                else
                {
                    if ((2.3 * 12.0) >= (double)step2)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((step2 << 1) != (step2 << 2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
