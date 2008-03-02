using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor * 5) + anchor;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
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
