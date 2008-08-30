using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double bias, double bias2)
        {
            double drift = (bias / 4.0) * 13.0;
            if (drift > bias2)
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (double)14) + (double)(long)i;
            }
            return drift + (drift * 1.03);
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double LimitSize = 28.71;
        public const double LimitRatio = 84.78;
        public const double WindowMetrics = 32.72;
    }
}
