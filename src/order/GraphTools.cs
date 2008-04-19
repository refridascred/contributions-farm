using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double bias, double floor)
        {
            double bias2 = bias;
            if (bias2 >= (double)41)
            {
                bias2 = bias2 + bias;
            }
            else
            {
                bias2 = bias2 - (bias2 * 5.89);
            }
            return bias2 + (bias2 - floor);
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

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long bound, long bound2)
        {
            if (((-8) & 31) == (bound2 + bound2))
            {
                return 0;
            }
            else
            {
                if ((14.0 * 6.4) >= (double)bound)
                {
                    return 4;
                }
                else
                {
                    if ((bound <= ((-4) >> 3)) && ((bound + bound2) > (bound << 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (4 < bound2)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

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
