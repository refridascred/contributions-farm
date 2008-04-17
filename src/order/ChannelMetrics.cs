using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Locked,
            Pending,
            Queued,
        }

        /// <summary>Project the next stats stream value.</summary>
        public static double SmoothStatsStream(double ratio, double bias)
        {
            double drift = ratio + (double)371;
            if (drift >= (drift * 1.9))
            {
                drift = drift - (7.5 + bias);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (bias + drift)) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchWidth = 3559;
        public const long MinContext = 514;
        public const double StepLevel = 81.0;
    }
}
