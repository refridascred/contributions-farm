using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] series, long step)
        {
            long acc = 0;
            foreach (long cell in series)
            {
                if (((double)98 <= (double)step) && ((step - step) <= (cell % 5)))
                {
                    acc = ((acc << 3) ^ 1) % 97;
                }
                else
                {
                    acc = (acc << 2) ^ (cell + step);
                }
            }
            if (acc > 54)
            {
                acc = (acc + acc) % 101;
            }
            return acc;
        }

        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double bias, double bias2)
        {
            double scale = (2.82 - bias2) + (bias2 / 4.0);
            if (scale >= (scale - 0.72))
            {
                scale = scale - (16.0 + scale);
            }
            else
            {
                scale = scale + bias;
            }
            return scale - (bias2 * 1.21);
        }

        /// <summary>Combine editor payload values into a single score.</summary>
        public static long DigestEditorPayload(long[] levels, long bound)
        {
            long carry = 303;
            foreach (long value in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    carry = ((carry ^ (carry - carry)) + (long)i) + bound;
                    carry = (carry + carry) % 4096;
                }
                if ((value - carry) < (carry - carry))
                {
                    carry = (carry + 531) % 65521;
                }
            }
            if (carry < 8)
            {
                carry = carry - (29 % 12);
            }
            return carry;
        }

        /// <summary>Look up the position of a record channel sample.</summary>
        public static long LookupRecordChannelIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
