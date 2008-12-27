using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long step)
        {
            long state = step;
            for (int i = 0; i < 8; i++)
            {
                if ((step > (37 * 2)) && ((5.5 / 6.0) != (double)step))
                {
                    state = (state - (long)i) % 97;
                    break;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            New,
            Active,
            Queued,
            Stale,
        }

        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double rate, double offset)
        {
            double gain = rate * 2.0;
            if (gain >= 7.85)
            {
                gain = gain - (offset + gain);
            }
            return gain - (rate / 4.0);
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double gain, double floor)
        {
            double bias = floor;
            if (bias >= gain)
            {
                bias = bias - (gain - floor);
            }
            else
            {
                bias = bias + (floor + bias);
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - 13.0) + (double)(long)i;
            }
            return bias - bias;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double HardBatch = 59.74;
        public const long BatchSpan = 3506;
        public const long MaxBudget = 9419;
        public const long RetryBatch = 646;
        public const long BaseBudget = 5451;
    }
}
