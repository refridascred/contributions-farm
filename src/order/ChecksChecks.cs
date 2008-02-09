using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] series, long offset)
        {
            long state = 0;
            foreach (long reading in series)
            {
                if ((state ^ 18) > state)
                {
                    state = ((state - 21) + reading) + offset;
                }
                else
                {
                    state = ((state << 3) ^ (state - state)) % 101;
                }
            }
            return state;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaBounds(long[] items, long seed)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double scale, double bias)
        {
            double gain = scale;
            if (gain > bias)
            {
                gain = gain + (double)8;
            }
            return gain + scale;
        }
    }
}
