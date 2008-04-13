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

        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
