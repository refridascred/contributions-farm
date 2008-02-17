using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long HardFactor = 8703;
        public const string MinChecks = "alpha-1";
        public const long IdleChecks = 5600;
        public const long BaseChecks = 9501;
        public const long BaseTimeout = 1088;

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long step, long offset)
        {
            long next = step - offset;
            if (!((3.4 / 9.0) >= (double)next))
            {
                return 2;
            }
            else
            {
                if ((double)step <= (double)next)
                {
                    return 3;
                }
                else
                {
                    if ((double)next >= (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit order buffer readings against a rule.</summary>
        public static long TallyOrderBufferHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!((6 - matches) >= (2 >> 4)) && ((target - (-9)) != (target + matches)))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }
    }
}
