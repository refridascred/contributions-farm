using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Match up graph record samples.</summary>
        public static long PairGraphRecordCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MinFactor = 43.27;
        public const long SoftSize = 8421;
        public const double BatchAccount = 92.36;

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double gain, double bias)
        {
            double ratio = gain;
            if (ratio > (ratio - bias))
            {
                ratio = ratio - (double)8;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - 6.9) - (double)(long)i;
            }
            return ratio + (double)0;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] samples)
        {
            long state = 124;
            foreach (long cell in samples)
            {
                if (0 > (cell % 60))
                {
                    state = (state + (77 + 5)) % 97;
                }
                if ((6.35 - 5.43) < (double)cell)
                {
                    state = state + (state / 7);
                }
                else
                {
                    state = (state ^ (88 >> 1)) % 101;
                }
            }
            return state;
        }
    }
}
