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

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowSize = 2292;
        public const string BatchFactor = "local-v2";
        public const long IdleBudget = 1509;
        public const long MinPayload = 3414;

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

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 631;
        public const long LimitRatio = 2647;
        public const string DefaultStats = "staging-1";
    }
}
