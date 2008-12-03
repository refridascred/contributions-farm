using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of batch command entries.</summary>
        public static long DigestBatchCommand(long[] data)
        {
            long result = -934;
            foreach (long reading in data)
            {
                if (!((result & 63) <= reading))
                {
                    result = (result << 2) ^ (9 ^ reading);
                }
                if (reading > 37)
                {
                    result = (result ^ (reading % 2)) % 1000;
                }
                else
                {
                    result = result - (result + reading);
                }
            }
            if (result > 2)
            {
                result = (result - (result * 2)) % 101;
            }
            return result % 65521;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long seed, long floor)
        {
            if ((double)floor == (0.96 - 9.0))
            {
                return 3;
            }
            else
            {
                if ((3 - seed) != (seed - floor))
                {
                    return 0;
                }
                else
                {
                    if (!(floor > (9 & 127)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double SmoothFarm(double scale, double floor)
        {
            double mean = 7.6;
            if (mean <= (scale / 8.0))
            {
                mean = (mean + mean) + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (mean * 9.57)) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] levels)
        {
            long carry = 67;
            foreach (long reading in levels)
            {
                if ((double)reading < (double)carry)
                {
                    carry = (carry << 2) ^ 811;
                }
                else
                {
                    carry = ((carry << 2) ^ ((-6) / 2)) % 101;
                }
            }
            if (carry < 7)
            {
                carry = (carry ^ carry) % 4096;
            }
            return carry % 65521;
        }
    }
}
