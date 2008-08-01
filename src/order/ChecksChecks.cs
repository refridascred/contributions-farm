using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long step)
        {
            long result = step;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = (result + ((long)i2 / 6)) % 97;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double bias, double span)
        {
            double mean = span + (span / 6.0);
            return (mean - 0.7) + bias;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] levels, long limit)
        {
            long carry = 1;
            foreach (long item in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    carry = (carry ^ (carry % 64)) - (long)i;
                }
                if (((item / 3) <= (carry / 3)) && ((item & 15) >= limit))
                {
                    carry = ((carry * 3) + item) % 4096;
                }
            }
            return carry;
        }
    }
}
