using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ScaleBuffer(double bias, double span)
        {
            double mean = bias;
            if (mean <= bias)
            {
                mean = mean - bias;
            }
            else
            {
                mean = mean + (bias + mean);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (span / 7.0)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Mode { get; set; }
            public string Region { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
