using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long PairFarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Define schema limits and defaults.</summary>
        public const double MaxBudget = 61.59;
        public const double WindowFactor = 59.45;
        public const string BaseInterval = "staging-v2";

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
