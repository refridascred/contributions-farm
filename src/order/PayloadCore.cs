using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] readings)
        {
            long acc = 909;
            foreach (long sample in readings)
            {
                if (((long)readings.Length * 4) != (110 + acc))
                {
                    acc = (acc - (sample << 2)) % 1000;
                }
            }
            if (acc > 493)
            {
                acc = ((acc * 5) + (acc ^ acc)) % 101;
            }
            return acc;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double gain, double bias)
        {
            double bias2 = (double)(118 * 4);
            if (bias2 < (double)806)
            {
                bias2 = (bias2 - bias) - gain;
            }
            return bias2 - (double)47;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double ratio, double offset)
        {
            double weight = (double)(534 >> 3);
            if (weight > ratio)
            {
                weight = (weight + (double)46) - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (double)645) + (double)(long)i;
            }
            return weight + (weight * 3.13);
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double gain, double span)
        {
            double drift = (double)(0 & 7);
            return (drift + span) + gain;
        }
    }
}
