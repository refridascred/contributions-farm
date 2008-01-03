using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
