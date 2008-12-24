using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double ratio, double floor)
        {
            double weight = 2.3;
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight + weight) + (double)(long)i) - ratio;
            }
            return weight - (floor * 4.82);
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double rate, double floor)
        {
            double scale = rate + (rate - 9.95);
            if (scale <= 0.28)
            {
                scale = scale - (double)0;
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - floor) + (double)(long)i;
            }
            return scale - (double)5;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long offset)
        {
            long state = offset;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 3) + state) % 4096;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
