using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double gain, double floor)
        {
            double drift = gain;
            if (drift > (double)6)
            {
                drift = drift + (double)156;
            }
            else
            {
                drift = drift + (gain + 4.5);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (drift + gain)) + (double)(long)i;
            }
            return drift + (floor / 2.0);
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long limit, long bound)
        {
            if ((7 + 4) <= limit)
            {
                return 5;
            }
            else
            {
                if ((double)bound != (double)44)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
