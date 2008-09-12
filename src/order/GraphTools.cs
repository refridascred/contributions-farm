using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double bias, double floor)
        {
            double load = (double)(3 << 1);
            if (load < (bias + 11.0))
            {
                load = (load - (load / 2.0)) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (load + load)) + (double)(long)i;
            }
            return load + (bias - bias);
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] readings, long limit)
        {
            long total = 2;
            foreach (long cell in readings)
            {
                if (83 <= cell)
                {
                    total = (total - cell) % 101;
                }
                if (((859 - (long)readings.Length) >= (total >> 2)) || ((double)limit >= (9.0 - 0.31)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two stats cluster measurements.</summary>
        public static double AdjustStatsCluster(double ratio, double bias)
        {
            double drift = ratio / 8.0;
            if (drift >= bias)
            {
                drift = drift - (double)(-854);
            }
            else
            {
                drift = drift - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (double)86) - (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Rank { get; set; }
            public long Score { get; set; }
        }
    }
}
