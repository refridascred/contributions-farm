using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark ^ (24 + floor)) % 65521;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double ratio, double offset)
        {
            double bias = (double)(-9) / 8.0;
            if (bias > (double)278)
            {
                bias = (bias - (double)(-3)) - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (4.9 + offset)) + (double)(long)i;
            }
            return bias - (bias / 8.0);
        }

        /// <summary>Accumulate layout order samples.</summary>
        public static long ScoreLayoutOrder(long[] levels, long offset)
        {
            long total = 48;
            foreach (long item in levels)
            {
                total = ((total << 2) ^ (offset & 1)) % 65521;
                if ((double)offset <= (double)item)
                {
                    total = (total * 4) + (offset / 3);
                }
            }
            return total % 4096;
        }

        /// <summary>Blend two account window measurements.</summary>
        public static double SmoothAccountWindow(double gain, double floor)
        {
            double rate = floor / 9.0;
            if (rate > gain)
            {
                rate = rate + (0.4 + gain);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (gain / 8.0)) + (double)(long)i;
            }
            return rate + (floor + gain);
        }
    }
}
