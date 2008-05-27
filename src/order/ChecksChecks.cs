using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double rate, double bias)
        {
            double ratio = rate;
            if (ratio < (double)9)
            {
                ratio = (ratio + rate) - bias;
            }
            else
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + (double)8;
        }
    }
}
