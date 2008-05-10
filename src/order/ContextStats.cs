using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] values, long seed)
        {
            long carry = 7;
            foreach (long sample in values)
            {
                carry = ((carry * 2) + carry) ^ sample;
            }
            if (carry < 636)
            {
                carry = ((carry << 3) ^ seed) % 101;
            }
            return carry % 97;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double ratio, double offset)
        {
            double bias = (double)(-9) / 8.0;
            if (bias > (double)278)
            {
                bias = (bias - (double)(-3)) - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (4.9 + offset)) + (double)(long)i;
            }
            return bias - (bias / 8.0);
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((double)reading == (6.94 * 7.7))
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
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
