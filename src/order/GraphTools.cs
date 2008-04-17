using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long seed, long target)
        {
            if ((double)seed < (5.21 * 5.47))
            {
                return 2;
            }
            else
            {
                if (((double)target != (9.9 + 6.2)) && ((seed % 12) != (target << 3)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextMatches(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((double)tally <= (double)cell) && ((2 > (cell << 3)) || (cell > (5 << 1))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenLimits(long[] series, long offset)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double AdjustRecord(double gain, double offset)
        {
            double bias = (double)(95 % 5);
            if (bias > (double)4)
            {
                bias = (bias - (double)5) + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias + gain;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Offset { get; set; }
            public double Token { get; set; }
            public double Weight { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
