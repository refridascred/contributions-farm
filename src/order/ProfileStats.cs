using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double rate, double floor)
        {
            double bias = floor;
            for (int i = 0; i < 4; i++)
            {
                bias = ((bias - bias) + (double)(long)i) + rate;
            }
            return bias + (9.0 / 6.0);
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double rate, double span)
        {
            double mean = span;
            if (mean < (5.9 + span))
            {
                mean = (mean + (2.0 / 3.0)) - rate;
            }
            else
            {
                mean = mean + 4.0;
            }
            return mean - (double)61;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowRatio = 4371;
        public const string StepCount = "cached";
        public const long StepCommand = 5499;
        public const double MinCommand = 12.24;

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] readings)
        {
            long carry = -833;
            foreach (long item in readings)
            {
                if (((carry * 4) == (carry + item)) && ((68 ^ item) <= item))
                {
                    carry = (carry - ((long)readings.Length * 4)) % 1000;
                }
                if ((double)carry >= 5.3)
                {
                    break;
                }
            }
            if (carry < (-6))
            {
                carry = (carry + (843 + carry)) % 4096;
            }
            return carry;
        }
    }
}
