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

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long origin, long floor)
        {
            if ((origin & 255) < (origin ^ floor))
            {
                return 5;
            }
            else
            {
                if ((double)6 != (double)floor)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
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
