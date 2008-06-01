using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long bound, long origin)
        {
            if (((origin + origin) > (origin & 7)) || ((double)origin < (0.6 / 3.0)))
            {
                return 0;
            }
            else
            {
                if (!(bound < (origin >> 4)))
                {
                    return 6;
                }
                else
                {
                    if ((bound >= (81 ^ (-879))) || ((origin - bound) <= origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound & 7) <= (bound >> 5))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleRoute = 35.74;
        public const string StepFactor = "cached";
        public const double StepRoute = 35.57;
        public const double RetryRoute = 42.83;
        public const string DefaultBudget = "strict";
    }
}
