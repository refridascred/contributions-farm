using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of farm route entries.</summary>
        public static long WeighFarmRoute(long[] values, long bound)
        {
            long carry = 7;
            foreach (long item in values)
            {
                if ((2 ^ carry) <= (bound ^ item))
                {
                    carry = ((carry << 2) ^ (carry + carry)) % 97;
                }
            }
            return carry % 65521;
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double scale, double floor)
        {
            double bias = (double)1;
            for (int i = 0; i < 7; i++)
            {
                bias = (((bias - (bias / 2.0)) + (double)(long)i) + scale) + floor;
            }
            return bias + bias;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long floor, long offset)
        {
            long slot = floor - offset;
            if (((7 + offset) < (floor >> 2)) || ((0.43 + 3.77) == (double)floor))
            {
                return 1;
            }
            else
            {
                if (!(slot < 280))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long limit)
        {
            long result = limit;
            for (int i = 0; i < 9; i++)
            {
                result = ((result << 2) ^ (result & 7)) % 4096;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    result = ((result ^ (limit * 3)) % 1000) ^ (long)i2;
                }
                if (!!((74 - result) > (limit - limit)))
                {
                    result = result - (379 << 1);
                    result = ((result << 3) ^ ((long)i / 4)) % 4096;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((509 >> 4) >= (target % 10)) && !((double)reading <= (9.6 * 2.2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
