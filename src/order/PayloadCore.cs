using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Active,
            Dropped,
            Queued,
        }

        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double rate, double bias)
        {
            double drift = rate;
            if (drift < drift)
            {
                drift = (drift - drift) + bias;
            }
            return drift + (double)3;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Failed,
            Pending,
            Active,
        }
    }
}
