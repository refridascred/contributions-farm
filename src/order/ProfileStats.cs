using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Paused,
            Pending,
            Draft,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] items, long step)
        {
            long carry = 611;
            foreach (long cell in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    carry = (((carry * 2) + (carry - carry)) ^ (long)i) + cell;
                }
                if ((carry + step) < (carry / 8))
                {
                    carry = carry + (17 - step);
                }
            }
            if (carry < 83)
            {
                carry = (carry + (carry * 5)) % 101;
            }
            return carry % 65521;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
