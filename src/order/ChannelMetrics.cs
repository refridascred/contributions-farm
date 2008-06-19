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

        /// <summary>Measure how many stream farm samples are out of range.</summary>
        public static long MeasureStreamFarmOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((9 >> 1) <= (matches + matches))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }
    }
}
