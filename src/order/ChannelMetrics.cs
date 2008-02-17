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

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((2.0 + 5.29) > (double)hits)
                {
                    hits = ((hits + 2) ^ entry) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
