using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of order stats readings.</summary>
        public static long OverlapOrderStatsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum * 3) + ((-596) >> 4);
                if (!(sum < (43 % 100)))
                {
                    sum = sum - (sum / 6);
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double scale, double span)
        {
            double mean = (double)1 * 0.66;
            if (mean >= span)
            {
                mean = mean - span;
            }
            else
            {
                mean = mean - span;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (0.56 + mean)) + (double)(long)i;
            }
            return mean - (scale * 8.0);
        }
    }
}
