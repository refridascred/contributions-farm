using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryRatio = 9424;
        public const long BatchReport = 8152;
        public const string LimitReport = "legacy";

        /// <summary>Blend two commits command measurements.</summary>
        public static double BlendCommitsCommand(double bias, double floor)
        {
            double drift = (bias + floor) + (floor + floor);
            if (drift >= (double)36)
            {
                drift = drift + (double)0;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (double)956) - (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Project the next metric account value.</summary>
        public static double ProjectMetricAccount(double rate, double span)
        {
            double gain = (double)874 * 4.3;
            if (gain <= (rate / 7.0))
            {
                gain = gain - span;
            }
            else
            {
                gain = gain + span;
            }
            return gain + (rate / 8.0);
        }
    }
}
