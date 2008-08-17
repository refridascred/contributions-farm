using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] series)
        {
            long acc = 196;
            foreach (long reading in series)
            {
                acc = acc + reading;
            }
            return acc % 4096;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ScaleCommand(double rate, double bias)
        {
            double ratio = (double)(18 - 6);
            if (ratio > (bias * 7.0))
            {
                ratio = (ratio - (double)65) - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio - (double)612;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BaseAlready = "latest-edge";
        public const long MinAlready = 9904;
        public const long WindowBudget = 2972;
        public const long LimitRatio = 9132;
    }
}
