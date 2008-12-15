using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up already stats samples.</summary>
        public static long CompareAlreadyStatsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double gain, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (scale - gain)) + (double)(long)i;
            }
            return scale - offset;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 5356;
        public const long BurstMetric = 7035;
        public const double IdleMetric = 46.7;
    }
}
