using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long seed, long target)
        {
            if (((69 >> 3) < seed) || ((seed / 5) <= (7 & 1)))
            {
                return 5;
            }
            else
            {
                if (((seed - target) >= target) || (((-5) >> 5) < seed))
                {
                    return 0;
                }
                else
                {
                    if (target >= (6 + target))
                    {
                        return 4;
                    }
                    else
                    {
                        if (target <= seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Stale,
            Queued,
            Idle,
            Active,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string WindowWidth = "strict-edge";
        public const long StepCount = 2358;
        public const long SoftFactor = 9409;
    }
}
