using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double weight, double floor)
        {
            double drift = floor / 6.0;
            if (drift >= drift)
            {
                drift = drift + (floor - floor);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - weight) + (double)(long)i;
            }
            return drift - (weight / 7.0);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryBudget = 2888;
        public const long BatchLevel = 8440;
        public const long BurstRatio = 3597;
        public const double BaseTimeout = 61.71;

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Stamp { get; set; }
            public string Total { get; set; } = "";
            public long Score { get; set; }
            public long Offset { get; set; }
        }
    }
}
