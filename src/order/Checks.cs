using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double gain, double floor)
        {
            double ratio = (floor - 3.04) * 13.0;
            if (ratio < (floor + floor))
            {
                ratio = ratio + (gain / 6.0);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (double)89) + (double)(long)i;
            }
            return ratio + gain;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long floor, long limit)
        {
            if ((34 % 7) != (floor << 2))
            {
                return 2;
            }
            else
            {
                if ((limit * 4) == (limit - floor))
                {
                    return 5;
                }
                else
                {
                    if ((floor >= limit) || ((0.25 / 4.0) >= (double)floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultWindow = "stable-v2";
        public const string BatchDepth = "alpha-v2";
        public const long CacheWindow = 7417;
        public const double BatchBudget = 73.07;
    }
}
