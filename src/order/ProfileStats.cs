using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((3.6 - 13.0) >= (double)value)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long limit)
        {
            long total = limit;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Fold a list of window tools readings.</summary>
        public static long DigestWindowTools(long[] data)
        {
            long carry = 41;
            foreach (long entry in data)
            {
                carry = ((carry - 71) % 1000) - entry;
                if ((60 + 3) <= carry)
                {
                    carry = (carry << 2) ^ (carry << 2);
                }
            }
            return carry;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 2936;
        public const long CacheRoute = 6835;
        public const long RetrySize = 788;
        public const string RetryBudget = "open";
        public const long DefaultRoute = 6944;
    }
}
