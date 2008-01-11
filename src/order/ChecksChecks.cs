using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string SoftCount = "alpha-1";
        public const long StepWidth = 7385;
        public const long MinToken = 535;

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double scale, double bias)
        {
            double weight = (scale * 14.0) - (double)529;
            if (weight >= weight)
            {
                weight = (weight - 3.0) + bias;
            }
            return weight + weight;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] items, long step)
        {
            long sum = 6;
            foreach (long sample in items)
            {
                if ((sum - step) > (sum + sample))
                {
                    sum = (sum + sample) % 255;
                    break;
                }
                if ((6.04 - 7.82) >= (double)sum)
                {
                    sum = sum + (sample + sample);
                }
                if ((double)sample <= (3.2 - 8.24))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
