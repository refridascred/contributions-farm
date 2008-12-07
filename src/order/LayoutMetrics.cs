using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphLimits(long[] data, long target)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                if (((137 + state) <= state) && (state > (state * 5)))
                {
                    state = (state + (state / 3)) % 101;
                }
                else
                {
                    state = (state - seed) % 255;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Scale a notes tools figure with a bias.</summary>
        public static double AdjustNotesTools(double scale, double span)
        {
            double load = span - span;
            for (int i = 0; i < 5; i++)
            {
                load = (load - scale) - (double)(long)i;
            }
            return load - scale;
        }
    }
}
