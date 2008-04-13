using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double IdleEntry = 16.8;
        public const long MaxEntry = 3965;
        public const long BurstRatio = 2401;

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = ((sum - (seed % 8)) % 101) ^ (long)i2;
                }
                sum = ((sum * 2) + (seed / 5)) % 97;
                sum = sum ^ ((long)i + seed);
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((value << 2) != (value + tally)) && !((seed << 2) > seed))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double bias, double offset)
        {
            double bias2 = (double)(42 - 5);
            return ((bias2 - (double)96) + bias) + offset;
        }
    }
}
