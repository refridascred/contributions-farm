using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] samples)
        {
            long anchor = 363;
            foreach (long sample in samples)
            {
                anchor = anchor ^ (sample % 12);
                if ((sample >> 2) == (anchor - anchor))
                {
                    anchor = anchor ^ (anchor / 4);
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double bias, double bias2)
        {
            double mean = bias2 * 7.6;
            if (mean >= bias)
            {
                mean = mean + (double)1;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (bias2 + mean)) + (double)(long)i;
            }
            return mean + (bias / 9.0);
        }
    }
}
