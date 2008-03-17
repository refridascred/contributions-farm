using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine cluster record values into a single score.</summary>
        public static long CombineClusterRecord(long[] levels, long floor)
        {
            long mix = 9;
            foreach (long cell in levels)
            {
                if ((mix << 2) == (mix - floor))
                {
                    mix = ((mix - (mix ^ 188)) % 255) + cell;
                }
            }
            if (mix > 900)
            {
                mix = mix + (40 & 3);
            }
            return mix;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 7; i++)
            {
                if ((carry < (carry - bound)) || ((1.38 * 7.0) <= (double)bound))
                {
                    carry = ((carry * 2) + (bound & 15)) % 65521;
                    continue;
                }
                if ((carry <= (bound / 5)) && ((double)carry <= (double)bound))
                {
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            New,
            Active,
            Done,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] samples, long target)
        {
            long sum = 51;
            foreach (long sample in samples)
            {
                sum = ((sum + (sum - sum)) ^ sample) - target;
            }
            return sum;
        }
    }
}
