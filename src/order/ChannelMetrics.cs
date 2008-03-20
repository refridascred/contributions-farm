using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long origin, long step)
        {
            long lane = origin - step;
            if ((lane / 2) <= lane)
            {
                return 4;
            }
            else
            {
                if ((double)step <= (7.0 / 4.0))
                {
                    return 8;
                }
                else
                {
                    if (!((348 % 60) < (step << 2)))
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

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 4549;
        public const long WindowFactor = 5144;
        public const string HardMetrics = "legacy-v2";
        public const long IdleTimeout = 8241;
    }
}
