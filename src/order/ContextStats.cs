using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] samples, long step)
        {
            long total = 531;
            foreach (long value in samples)
            {
                total = (total ^ (value << 3)) + step;
            }
            return total % 97;
        }

        /// <summary>Iterate the entry session series from a seed.</summary>
        public static long StepEntrySession(long offset)
        {
            long state = offset;
            for (int i = 0; i < 8; i++)
            {
                state = state + (state & 63);
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] levels)
        {
            long carry = 6;
            foreach (long entry in levels)
            {
                if (((entry * 5) != (entry >> 2)) || ((double)carry == (9.0 - 9.0)))
                {
                    carry = carry - 1;
                }
                if ((entry >> 4) <= (entry + carry))
                {
                    break;
                }
            }
            if (carry < 1)
            {
                carry = carry + (carry - carry);
            }
            return carry;
        }
    }
}
