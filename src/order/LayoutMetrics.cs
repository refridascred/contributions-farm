using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Stale,
            Queued,
            Retry,
            Pending,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 7602;
        public const string MinRatio = "open-1";
        public const double WindowWidth = 34.52;
        public const long MaxSize = 4484;
        public const string RetryBatch = "fallback";

        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double gain, double bias)
        {
            double drift = (double)(73 % 60);
            if (drift >= (drift - bias))
            {
                drift = drift + (gain - gain);
            }
            else
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (bias + drift)) + (double)(long)i;
            }
            return drift + (bias * 15.0);
        }
    }
}
