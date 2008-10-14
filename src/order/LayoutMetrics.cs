using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Limit { get; set; } = "";
            public long Score { get; set; }
            public double Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ScaleRoute(double gain, double offset)
        {
            double mean = gain;
            if (mean <= (double)263)
            {
                mean = mean - (gain - offset);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (gain - offset)) + (double)(long)i;
            }
            return mean + (mean - gain);
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
