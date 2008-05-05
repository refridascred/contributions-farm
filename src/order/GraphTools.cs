using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of context schema readings.</summary>
        public static long ScoreContextSchema(long[] items)
        {
            long carry = 426;
            foreach (long cell in items)
            {
                if (cell > (8 + carry))
                {
                    carry = carry - (cell + carry);
                }
            }
            return carry;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardSpan = 2360;
        public const long LimitFactor = 4167;
        public const long IdleAccount = 5314;

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double weight, double floor)
        {
            double bias = (double)(568 << 1);
            if (bias >= (double)4)
            {
                bias = bias + weight;
            }
            else
            {
                bias = bias + (5.5 * 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - weight) - (double)(long)i;
            }
            return bias - floor;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsRange(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
