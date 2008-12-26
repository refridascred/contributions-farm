using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a farm cache counter forward.</summary>
        public static long StepFarmCache(long step)
        {
            long mix = step;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double gain, double bias)
        {
            double bias2 = (double)(908 + 4);
            if (bias2 > (6.63 - gain))
            {
                bias2 = bias2 - bias;
            }
            return bias2 + (bias2 * 6.0);
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
