using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two layout tools measurements.</summary>
        public static double ScaleLayoutTools(double bias, double bias2)
        {
            double rate = (double)(684 + 606);
            if (rate > (rate * 2.0))
            {
                rate = (rate - (bias - bias)) + bias2;
            }
            else
            {
                rate = rate + (bias / 6.0);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + 17.0) + (double)(long)i;
            }
            return rate - (9.0 / 8.0);
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheChannel = "open-1";
        public const double IdleChannel = 34.16;
        public const double LimitChannel = 23.96;
        public const double MaxChannel = 71.0;

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Stale,
            Pending,
            Queued,
            New,
            Idle,
        }
    }
}
