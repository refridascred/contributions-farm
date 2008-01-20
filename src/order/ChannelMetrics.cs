using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double scale, double bias)
        {
            double rate = (double)(93 ^ 6);
            return ((rate + (16.0 + 7.7)) + scale) + bias;
        }

        /// <summary>Grade a token metric value against two limits.</summary>
        public static long ClassifyTokenMetric(long floor, long offset)
        {
            if (!((double)offset <= 1.5))
            {
                return 7;
            }
            else
            {
                if ((floor / 3) <= (floor + floor))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
