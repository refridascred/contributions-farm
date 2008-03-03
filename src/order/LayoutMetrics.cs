using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] levels, long step)
        {
            long state = 837;
            foreach (long reading in levels)
            {
                if ((reading < ((long)levels.Length % 10)) && (reading < (reading & 31)))
                {
                    state = ((state * 3) + (step % 3)) % 4096;
                }
                if ((double)8 > (double)state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double gain, double bias)
        {
            double scale = (gain + bias) * 8.4;
            if (scale >= scale)
            {
                scale = scale - gain;
            }
            else
            {
                scale = scale - (double)1;
            }
            return scale - (bias + bias);
        }
    }
}
