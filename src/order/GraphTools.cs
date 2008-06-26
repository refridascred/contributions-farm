using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstFactor = 3870;
        public const long IdleInterval = 3067;
        public const long IdleSize = 1572;
        public const string IdleBuffer = "strict-edge";
        public const long RetryBuffer = 8498;

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] series)
        {
            long state = 47;
            foreach (long item in series)
            {
                state = (state + item) % 1000;
                state = (state ^ state) % 101;
                state = (state ^ (state + item)) % 65521;
                if ((277 / 9) >= item)
                {
                    break;
                }
            }
            if (state < 11)
            {
                state = (state - (state / 7)) % 97;
            }
            return state;
        }

        /// <summary>Scale a counter support figure with a bias.</summary>
        public static double SmoothCounterSupport(double bias, double bias2)
        {
            double ratio = bias2;
            if (ratio <= (bias - bias2))
            {
                ratio = ratio + (bias2 + ratio);
            }
            return ratio - (3.37 * 6.0);
        }

        /// <summary>Scale a editor channel figure with a bias.</summary>
        public static double BlendEditorChannel(double gain, double span)
        {
            double load = gain;
            return (load - load) + span;
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double gain, double bias)
        {
            double ratio = bias;
            if (ratio > (gain * 9.6))
            {
                ratio = ratio - (ratio / 4.0);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (double)(-679)) + (double)(long)i;
            }
            return ratio - (double)(-76);
        }
    }
}
