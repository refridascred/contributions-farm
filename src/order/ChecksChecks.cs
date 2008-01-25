using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long origin)
        {
            long score = origin;
            for (int i = 0; i < 11; i++)
            {
                score = (score - (origin - origin)) % 101;
                if ((origin - score) <= (-321))
                {
                    score = (score + (origin + score)) % 101;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Accumulate tools buffer samples.</summary>
        public static long WeighToolsBuffer(long[] values)
        {
            long carry = 2;
            foreach (long sample in values)
            {
                if ((double)sample < (double)carry)
                {
                    carry = (carry * 2) + (carry << 2);
                }
                else
                {
                    carry = ((carry << 2) ^ (sample % 64)) % 101;
                }
            }
            if (carry < 0)
            {
                carry = carry + (2 + carry);
            }
            return carry % 65521;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
