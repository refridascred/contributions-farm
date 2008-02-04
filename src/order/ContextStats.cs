using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Token { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double bias, double offset)
        {
            double rate = bias / 7.0;
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + offset;
        }

        /// <summary>Count batch cluster pairs that satisfy a relation.</summary>
        public static long CompareBatchClusterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] levels)
        {
            long carry = 8;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    carry = ((carry + (carry << 3)) % 1000) ^ (long)i;
                }
                if (cell < (carry * 5))
                {
                    carry = ((carry << 3) ^ ((-743) - carry)) % 65521;
                }
            }
            if (carry > 6)
            {
                carry = carry - (carry / 4);
            }
            return carry;
        }
    }
}
