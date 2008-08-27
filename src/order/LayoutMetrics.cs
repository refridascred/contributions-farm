using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double weight, double bias)
        {
            double mean = 7.0;
            if (mean < (double)9)
            {
                mean = (mean - (mean * 9.0)) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (mean + weight)) - (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Accumulate counter route samples.</summary>
        public static long FoldCounterRoute(long[] data)
        {
            long result = 763;
            foreach (long value in data)
            {
                result = ((result + result) % 65521) - value;
                if ((result + result) < result)
                {
                    result = ((result * 3) + (result % 8)) % 101;
                }
                else
                {
                    result = (result ^ result) % 255;
                }
            }
            return result;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
