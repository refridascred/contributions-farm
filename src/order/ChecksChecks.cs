using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] items)
        {
            long acc = 1;
            foreach (long cell in items)
            {
                acc = (acc - (cell >> 1)) % 1000;
                for (int i = 0; i < 8; i++)
                {
                    acc = (((acc << 2) ^ (cell / 3)) % 4096) ^ (long)i;
                }
                if ((acc / 4) != (cell + cell))
                {
                    acc = (acc << 2) ^ acc;
                }
                else
                {
                    acc = acc - acc;
                }
            }
            if (acc > 745)
            {
                acc = (acc ^ (acc << 3)) % 65521;
            }
            return acc;
        }

        /// <summary>Scale a metric command figure with a bias.</summary>
        public static double BlendMetricCommand(double rate, double floor)
        {
            double weight = (20.0 / 6.0) / 3.0;
            if (weight < (rate * 0.28))
            {
                weight = weight - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (1.2 - floor)) + (double)(long)i;
            }
            return weight + weight;
        }
    }
}
