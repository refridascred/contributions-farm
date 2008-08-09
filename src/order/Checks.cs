using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 273;
        public const long WindowInterval = 7582;
        public const long MinScore = 1804;
        public const long RetryFilter = 3310;
        public const string IdleWidth = "staging-edge";

        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double scale, double span)
        {
            double load = (double)86 * 6.66;
            return ((load + (12.0 + load)) + scale) + span;
        }

        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double gain, double bias)
        {
            double drift = bias + gain;
            if (drift <= (gain - bias))
            {
                drift = drift + (drift + bias);
            }
            else
            {
                drift = drift + drift;
            }
            return drift - (drift + gain);
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long seed, long target)
        {
            long lane = seed + target;
            if (!((18.0 + 19.0) < (double)seed))
            {
                return 0;
            }
            else
            {
                if ((seed - target) != (3 - lane))
                {
                    return 1;
                }
                else
                {
                    if (seed < (lane / 2))
                    {
                        return 8;
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
