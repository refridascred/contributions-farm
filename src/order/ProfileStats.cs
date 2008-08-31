using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next route counter value.</summary>
        public static double AdjustRouteCounter(double ratio, double bias)
        {
            double rate = ratio;
            if (rate < (ratio / 9.0))
            {
                rate = (rate + ratio) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + rate) - (double)(long)i;
            }
            return rate + (ratio * 16.0);
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

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 8431;
        public const long BaseInterval = 8660;
        public const long IdleBuffer = 248;
        public const long CacheTimeout = 9598;

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Limit { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
        }
    }
}
