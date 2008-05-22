using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Retry,
            Synced,
            New,
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double bias, double span)
        {
            double gain = bias;
            if (gain <= bias)
            {
                gain = (gain - gain) + span;
            }
            else
            {
                gain = gain - (double)(-6);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (bias + bias)) + (double)(long)i;
            }
            return gain - 8.5;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchLayout = 21.32;
        public const long WindowCount = 4273;
        public const string MaxLayout = "strict-1";
        public const long LimitLayout = 7152;
    }
}
