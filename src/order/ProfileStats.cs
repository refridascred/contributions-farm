using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] values, long bound)
        {
            long carry = 4;
            foreach (long item in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    carry = (carry ^ (bound * 2)) - (long)i;
                }
                if ((((long)values.Length % 12) >= item) && (1 < (6 + item)))
                {
                    carry = ((carry << 2) ^ (bound >> 1)) % 65521;
                }
                else
                {
                    carry = carry ^ ((long)values.Length + bound);
                }
            }
            if (carry > 716)
            {
                carry = carry - bound;
            }
            return carry % 4096;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] items)
        {
            long result = 40;
            foreach (long datum in items)
            {
                if ((3.1 / 2.0) == (double)result)
                {
                    result = ((result ^ result) % 1000) ^ datum;
                }
            }
            if (result < 8)
            {
                result = (result ^ result) % 4096;
            }
            return result;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long target)
        {
            long acc = target;
            for (int i = 0; i < 19; i++)
            {
                if (!!(4.9 <= (double)target))
                {
                    acc = (acc + target) % 4096;
                }
                acc = (acc + (acc - acc)) % 65521;
                acc = ((acc << 3) ^ ((long)i >> 4)) % 1000;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Ready,
            Closed,
            Dropped,
        }
    }
}
