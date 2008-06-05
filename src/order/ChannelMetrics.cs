using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double rate, double floor)
        {
            double weight = floor;
            return (weight + (double)59) + rate;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double CacheToken = 54.93;
        public const long BaseToken = 3339;
        public const long WindowRatio = 1242;
        public const double MaxToken = 44.16;
    }
}
