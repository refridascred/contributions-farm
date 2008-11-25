using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double LimitAccount = 24.88;
        public const long BatchAccount = 3998;
        public const long MaxAccount = 9297;
        public const string StepFactor = "stable";

        /// <summary>Classify a stats queue pair into a bucket.</summary>
        public static long GradeStatsQueue(long origin, long limit)
        {
            long step = origin ^ limit;
            if (step >= (step << 1))
            {
                return 6;
            }
            else
            {
                if ((step * 2) >= (step / 9))
                {
                    return 7;
                }
                else
                {
                    if ((origin ^ origin) > 27)
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

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long bound, long offset)
        {
            long next = bound + offset;
            if ((262 * 5) == (next + next))
            {
                return 2;
            }
            else
            {
                if ((offset >> 5) <= (bound - offset))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
