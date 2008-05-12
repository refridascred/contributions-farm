using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a cache record sample.</summary>
        public static long FindCacheRecordIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum - (sum + 1)) % 4096;
                if (((double)sum == (9.0 / 3.0)) && (sum <= (step - (long)i)))
                {
                    sum = (sum + (step << 2)) % 1000;
                    continue;
                }
                else
                {
                    sum = (sum + (step << 3)) % 65521;
                    sum = (sum + (step >> 1)) % 255;
                }
                sum = (sum ^ (sum + sum)) % 4096;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Region { get; set; }
            public string Level { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] items)
        {
            long carry = 87;
            foreach (long cell in items)
            {
                if ((double)carry == (5.4 + 7.6))
                {
                    carry = ((carry + (carry >> 2)) % 1000) - cell;
                }
            }
            if (carry > 856)
            {
                carry = (carry ^ carry) % 4096;
            }
            return carry;
        }
    }
}
