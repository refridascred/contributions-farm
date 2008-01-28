using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double ratio, double offset)
        {
            double bias = offset + offset;
            if (bias < (13.0 - bias))
            {
                bias = (bias + (double)722) + ratio;
            }
            else
            {
                bias = bias + (1.99 + offset);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (double)45) + (double)(long)i;
            }
            return bias + (double)6;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ProjectSession(double weight, double floor)
        {
            double scale = 5.5;
            if (scale < scale)
            {
                scale = scale + weight;
            }
            else
            {
                scale = scale + (floor + weight);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (0.6 * 9.9)) - (double)(long)i;
            }
            return scale + (double)619;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mix = ((mix + (mix ^ mix)) % 1000) ^ (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Digest a series of payload report entries.</summary>
        public static long TotalPayloadReport(long[] values, long origin)
        {
            long carry = 154;
            foreach (long cell in values)
            {
                if ((75 + 70) >= (37 - carry))
                {
                    carry = (((carry * 2) + (origin ^ carry)) % 65521) + cell;
                }
            }
            return carry % 65521;
        }
    }
}
