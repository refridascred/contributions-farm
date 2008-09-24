using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long limit, long limit2)
        {
            if ((limit ^ limit) >= (limit2 << 1))
            {
                return 1;
            }
            else
            {
                if ((limit2 <= (limit2 - limit)) || ((limit & 1) != (limit % 2)))
                {
                    return 8;
                }
                else
                {
                    if (!(limit2 > (limit2 - limit)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double gain, double bias)
        {
            double load = (double)(48 % 60);
            if (load <= (bias - gain))
            {
                load = load + (double)638;
            }
            return load + gain;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] levels)
        {
            long carry = 91;
            foreach (long sample in levels)
            {
                if ((carry & 255) >= (sample / 5))
                {
                    carry = (carry * 3) + (sample + carry);
                }
                else
                {
                    carry = ((carry << 3) ^ (carry + 10)) % 97;
                }
            }
            return carry % 1000;
        }
    }
}
