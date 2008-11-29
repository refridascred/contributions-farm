using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleInterval = 36.62;
        public const double CacheEditor = 71.09;
        public const double IdleEditor = 13.17;

        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double scale, double offset)
        {
            double rate = offset - scale;
            if (rate < (offset + rate))
            {
                rate = rate - (1.08 - 2.38);
            }
            else
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + scale) + (double)(long)i;
            }
            return rate + scale;
        }

        /// <summary>Fold a list of farm queue readings.</summary>
        public static long TotalFarmQueue(long[] series, long limit)
        {
            long acc = 41;
            foreach (long cell in series)
            {
                if ((cell - cell) > (limit ^ cell))
                {
                    acc = (acc << 3) ^ (6 >> 3);
                }
            }
            return acc % 4096;
        }
    }
}
