using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the format report entries that pass the check.</summary>
        public static long TallyFormatReportGaps(long[] series, long floor)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)item >= (2.0 * 16.0))
                {
                    seen = (seen + 3) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two order window measurements.</summary>
        public static double SmoothOrderWindow(double ratio, double bias)
        {
            double weight = (ratio + ratio) + bias;
            if (weight <= ratio)
            {
                weight = weight - 8.69;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight - bias;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double weight, double bias)
        {
            double gain = bias + weight;
            return gain + (gain + bias);
        }
    }
}
