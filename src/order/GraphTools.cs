using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] items, long origin)
        {
            long score = 454;
            foreach (long value in items)
            {
                if ((7.0 + 7.5) >= (12.0 + 9.9))
                {
                    score = (((score << 2) ^ 2) % 97) + origin;
                }
                else
                {
                    score = (score - (value * 3)) % 65521;
                }
            }
            return score % 4096;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double bias, double floor)
        {
            double load = floor;
            if (load >= (double)2)
            {
                load = (load + load) - bias;
            }
            else
            {
                load = load + (load * 14.0);
            }
            return load - (8.6 / 8.0);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double WindowLevel = 9.18;
        public const long BatchEditor = 9240;
        public const long BurstEditor = 8323;
        public const double BatchFactor = 36.39;
        public const double LimitEditor = 4.62;

        /// <summary>Blend two farm measurements.</summary>
        public static double SmoothFarm(double rate, double offset)
        {
            double drift = (rate + rate) * 13.0;
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (3.0 + offset)) + (double)(long)i;
            }
            return drift - (double)(-18);
        }
    }
}
