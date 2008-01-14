using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double ratio, double span)
        {
            double gain = 7.0;
            if (gain < (ratio / 2.0))
            {
                gain = (gain - 8.48) + span;
            }
            else
            {
                gain = gain + 5.0;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - 10.0) + (double)(long)i;
            }
            return gain + (2.9 + 7.1);
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double gain, double offset)
        {
            double ratio = 2.7;
            if (ratio > 2.77)
            {
                ratio = (ratio + gain) + offset;
            }
            else
            {
                ratio = ratio + gain;
            }
            return ratio - ratio;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 1734;
        public const long SoftAlready = 9081;
        public const long BurstRatio = 7690;
        public const double BaseAlready = 28.5;
    }
}
