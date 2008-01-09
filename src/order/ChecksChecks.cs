using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two tools window measurements.</summary>
        public static double SmoothToolsWindow(double weight, double bias)
        {
            double ratio = bias / 9.0;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (7.3 / 2.0)) + (double)(long)i;
            }
            return ratio + weight;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 7; i++)
            {
                if ((seed + seed) > (long)i)
                {
                    continue;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double weight, double floor)
        {
            double drift = (double)((-98) - 508);
            return ((drift - (double)(-1)) + weight) + floor;
        }
    }
}
