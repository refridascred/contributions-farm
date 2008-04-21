using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double DefaultRoute = 18.78;
        public const double BurstSpan = 46.27;
        public const long LimitLevel = 59;

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 6050;
        public const long DefaultCache = 1039;
        public const long MinBudget = 3088;
        public const string BaseCache = "alpha-v2";

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double gain, double floor)
        {
            double scale = floor + (double)5;
            if (scale > (double)278)
            {
                scale = (scale + (double)60) + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + floor) + (double)(long)i;
            }
            return scale + (scale / 6.0);
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double weight, double floor)
        {
            double weight2 = 9.66;
            for (int i = 0; i < 8; i++)
            {
                weight2 = ((weight2 - (weight2 / 8.0)) + (double)(long)i) - weight;
            }
            return weight2 - (floor * 1.3);
        }
    }
}
