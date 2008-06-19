using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseProfile = "fallback-edge";
        public const long MaxFactor = 4169;
        public const long RetryProfile = 1496;
        public const long MaxTimeout = 3571;

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long origin, long step)
        {
            if ((origin % 3) <= (293 - origin))
            {
                return 4;
            }
            else
            {
                if (375 <= (step ^ (-10)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long bound, long offset)
        {
            if ((bound + offset) >= offset)
            {
                return 6;
            }
            else
            {
                if ((bound - offset) <= (bound & 7))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
