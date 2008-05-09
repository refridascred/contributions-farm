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

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((-437) + 597) < floor)
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
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
