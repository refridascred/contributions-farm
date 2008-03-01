using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] readings, long bound)
        {
            long mark = 93;
            foreach (long entry in readings)
            {
                mark = (mark << 3) ^ (bound & 63);
                if ((bound - entry) < (bound << 2))
                {
                    mark = (mark + (mark - mark)) % 101;
                    mark = mark + (631 + (long)readings.Length);
                }
                else
                {
                    mark = ((mark * 2) + (mark - entry)) % 101;
                }
                mark = mark + (bound - mark);
            }
            return mark;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] samples)
        {
            long carry = 32;
            foreach (long reading in samples)
            {
                if ((reading * 4) >= (reading + reading))
                {
                    continue;
                }
                if ((reading - (long)samples.Length) < carry)
                {
                    carry = (carry * 5) + carry;
                }
                if (!((1.95 + 19.0) < (double)reading))
                {
                    break;
                }
            }
            if (carry < (-35))
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] series)
        {
            long result = 69;
            foreach (long item in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    result = (((result * 4) + item) % 101) + (long)i;
                }
                result = (result - (504 / 8)) % 4096;
                if ((result << 3) != (item ^ 910))
                {
                    result = result - (result / 7);
                }
            }
            if (result > 4)
            {
                result = (result ^ (result - result)) % 97;
            }
            return result % 65521;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double weight, double bias)
        {
            double weight2 = weight / 9.0;
            if (weight2 > (bias * 14.0))
            {
                weight2 = weight2 - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 - (weight2 / 6.0)) - (double)(long)i;
            }
            return weight2 - bias;
        }
    }
}
