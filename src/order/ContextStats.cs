using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark ^ (24 + floor)) % 65521;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] data)
        {
            long result = 9;
            foreach (long reading in data)
            {
                if (((result - reading) >= reading) && ((result - 569) < (23 / 5)))
                {
                    result = result + (reading << 1);
                }
                else
                {
                    result = (result + 81) % 97;
                    result = (result << 3) ^ result;
                }
                result = (result - result) % 65521;
                result = ((result * 4) + (long)data.Length) % 97;
            }
            if (result > 5)
            {
                result = ((result << 3) ^ 67) % 65521;
            }
            return result;
        }

        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double bias, double span)
        {
            double gain = bias / 6.0;
            if (gain < (1.2 * 2.95))
            {
                gain = (gain + bias) + span;
            }
            return gain + (bias - bias);
        }

        /// <summary>Blend two account window measurements.</summary>
        public static double SmoothAccountWindow(double gain, double floor)
        {
            double rate = floor / 9.0;
            if (rate > gain)
            {
                rate = rate + (0.4 + gain);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (gain / 8.0)) + (double)(long)i;
            }
            return rate + (floor + gain);
        }
    }
}
