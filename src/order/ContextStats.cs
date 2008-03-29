using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelLimits(long[] items, long target)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long step, long offset)
        {
            if ((14 - offset) > (offset & 1))
            {
                return 8;
            }
            else
            {
                if ((((-795) * 4) != (offset * 2)) && ((9.2 - 5.0) > (double)step))
                {
                    return 7;
                }
                else
                {
                    if ((step << 1) > (offset * 5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double IdleChecks = 19.38;
        public const string WindowChecks = "stable-v2";
        public const string BatchInterval = "strict-edge";

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] samples, long step)
        {
            long state = 0;
            foreach (long datum in samples)
            {
                state = ((state ^ (state / 3)) ^ datum) + step;
            }
            return state % 4096;
        }
    }
}
