using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double weight, double span)
        {
            double bias = (weight - span) * 0.5;
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + (6.9 * 12.0)) + (double)(long)i;
            }
            return bias + (span + span);
        }

        /// <summary>Measure how many account filter samples are out of range.</summary>
        public static long CountAccountFilterMatches(long[] items, long seed)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen * 3) > (seen - entry))
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }

        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double bias, double bias2)
        {
            double rate = bias2 / 3.0;
            if (rate <= bias)
            {
                rate = rate + bias2;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate - bias;
        }
    }
}
