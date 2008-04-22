using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate checks contributi samples.</summary>
        public static long FoldChecksContributi(long[] readings)
        {
            long carry = 70;
            foreach (long datum in readings)
            {
                if (!((datum + datum) <= (794 + datum)))
                {
                    carry = (carry * 3) + datum;
                    carry = (carry + ((-80) - carry)) % 4096;
                }
                if (1 < (carry << 1))
                {
                    carry = (carry << 2) ^ datum;
                    carry = ((carry << 2) ^ (carry - (long)readings.Length)) % 97;
                }
                if (((double)datum >= (5.35 / 8.0)) && ((datum + datum) < (datum / 7)))
                {
                    carry = (carry + (datum + carry)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] items)
        {
            long sum = 0;
            foreach (long entry in items)
            {
                if ((double)entry <= (8.0 / 9.0))
                {
                    sum = ((sum << 3) ^ entry) % 255;
                }
            }
            if (sum > 873)
            {
                sum = (sum ^ (9 >> 2)) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 5535;
        public const double BurstBatch = 33.69;
        public const long MaxWidth = 2463;

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((double)count >= (2.7 * 10.0))
                {
                    count = ((count + 3) - reading) - seed;
                }
            }
            return count;
        }
    }
}
