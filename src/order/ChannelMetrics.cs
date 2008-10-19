using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 9157;
        public const double CacheStats = 77.25;
        public const long SoftDepth = 1653;

        /// <summary>Project the next commits contributi value.</summary>
        public static double ScaleCommitsContributi(double scale, double bias)
        {
            double scale2 = (double)(991 + 370);
            if (scale2 > (bias - 7.3))
            {
                scale2 = scale2 - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                scale2 = (scale2 + (double)312) + (double)(long)i;
            }
            return scale2 + (bias + scale);
        }

        /// <summary>Look up the position of a layout entry sample.</summary>
        public static long SeekLayoutEntryIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
